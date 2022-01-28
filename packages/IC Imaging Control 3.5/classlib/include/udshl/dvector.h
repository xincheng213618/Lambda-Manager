
#ifndef DVECTOR_H_INC_
#define DVECTOR_H_INC_

#pragma once

#include "udshl_defs.h"
#include "smart_ptr.h"

namespace _DSHOWLIB_NAMESPACE
{
	template<class TObj>
    class dvector
    {
    public:
        typedef TObj*		pointer;
        typedef TObj		value_type;
        typedef TObj&		reference;
        typedef const TObj&	const_reference;

        typedef pointer		iterator;
    public:
        dvector()
            : p_data_( 0 ), size_( 0 ), reserved_( 0 )
        {
        }
        explicit dvector( size_t size, size_t reserved_size = 0 )
            : p_data_( 0 ), size_( 0 ), reserved_( 0 )
        {
            if( size > reserved_size )
                reserved_size = size;
            uninitialized_alloc( reserved_size );
            uninitialized_construct( p_data_, size, TObj() );
        }
        template<class TIter>
        dvector( TIter assign_beg, TIter assign_end )
            : p_data_( 0 ), size_( 0 ), reserved_( 0 )
        {
            size_t diff = assign_end - assign_beg;
            uninitialized_alloc( diff );
            uninitialized_assign( assign_beg, diff );
        }
        dvector( pointer assign_beg, pointer assign_end )
            : p_data_( 0 ), size_( 0 ), reserved_( 0 )
        {
            size_t diff = assign_end - assign_beg;
            uninitialized_alloc( diff );
            uninitialized_assign( assign_beg, diff );
        }
        dvector( size_t size, pointer assign_beg, pointer assign_end )
            : p_data_( 0 ), size_( 0 ), reserved_( 0 )
        {
            uninitialized_alloc( size );

            size_t diff = min_( size_t( assign_end - assign_beg ), size );
            uninitialized_assign( assign_beg, diff );
            if( diff < size )
            {
                uninitialized_construct( p_data_ + diff, size - diff, TObj() );
            }
        }
        dvector( const dvector& op2 )
            : p_data_( 0 ), size_( 0 ), reserved_( 0 )
        {
            assign( op2.begin(), op2.end() );
        }

		~dvector()
		{
			pointer pDataEnd = p_data_ + size_;
			pointer pData = p_data_;
			while( pData < pDataEnd )
			{
				destroy( pData++ );
			}
			deallocate( p_data_, size_ );
		}

		template<class TIter>
		void	assign( TIter beg, TIter end )
		{
			dvector vTmp( beg, end );
			swap( vTmp );
		}
		void	resize( size_t newSize )
		{
			dvector vTmp( newSize, p_data_, p_data_ + size_ );
			swap( vTmp );
		}

		void	reserve( size_t newSize )
		{
			if( reserved_ >= newSize )	return;
			newSize = (newSize & (~0x1)) + 2;

			dvector reserve_vec( 0, newSize );
            if( size_ > 0 ) {
                reserve_vec.uninitialized_assign( p_data_, size_ );
            }
			swap( reserve_vec );
		}

		void	push_back( const_reference obj )
		{
			reserve( size_ + 1 );
			if( capacity() > size_ )
			{
				construct( p_data_ + size_, obj );
				size_ += 1;
			}
		}

		void	clear()
		{
			pointer pDataEnd = p_data_ + size_;
			pointer pData = p_data_;
			while( pData < pDataEnd )
			{
				destroy( pData++ );
			}
			deallocate( p_data_, size_ );

			p_data_ = 0;
			size_ = 0;
			reserved_ = 0;
		}

		iterator				begin()	const			{ return p_data_ + 0; }
		iterator				end()	const			{ return p_data_ + size_; }

		reference				operator[]( size_t i )			{ return p_data_[i]; }
		const_reference			operator[]( size_t i ) const	{ return p_data_[i]; }

		reference				front()					{ return p_data_[0]; }
		const_reference			front()	const			{ return p_data_[0]; }

		reference				back()					{ return p_data_[size_-1]; }
		const_reference			back()	const			{ return p_data_[size_-1]; }

		size_t		size() const						{ return size_; }
		bool		empty() const						{ return size_ == 0; }
		size_t		capacity() const					{ return reserved_; }

		pointer			data()								{ return p_data_; }
		const pointer	data()	const						{ return p_data_; }

		void	swap( dvector& op2 )
		{
			std::swap( p_data_, op2.p_data_ );
			std::swap( size_, op2.size_ );
			std::swap( reserved_, op2.reserved_ );
		}

		dvector&		operator=( const dvector& op2 )
		{
			dvector vTmp( op2 );
			swap( vTmp );
			return *this;
		}

		bool			operator==( const dvector& op2 ) const
		{
            if( size() != op2.size() )
            {
                return false;
            }
			iterator j = op2.begin();
			for( iterator i = begin(); i != end(); ++i )
			{
                if( !(*i == *j) ) {
                    return false;
                }
			}
			return true;
		}
		bool			operator!=( const dvector& op2 ) const      { return !(*this == op2); }
	private:
		size_t min_( size_t a, size_t b )
		{
			return (a < b) ? a : b;
		}
		void	uninitialized_alloc( size_t s )
		{
			size_ = 0;
			reserved_ = 0;
			if( s == 0 )
			{
				p_data_ = 0;
			}
			else
			{
				p_data_ = static_cast<pointer>( ::CoTaskMemAlloc( s * sizeof( value_type ) ) );
				if( p_data_ != 0 )
                {
					reserved_ = s;
                }
			}
		}
		template<class TIter>
		void	uninitialized_assign( TIter iter, size_t cnt )
		{
			while( size_ < cnt )
			{
				construct( p_data_ + size_, *iter );
				++iter;
				++size_;
			}
		}
		void	uninitialized_construct( pointer beg, size_t cnt, const TObj& ctor )
		{
			while( size_ < cnt ) {
				construct( beg + size_++, ctor );
            }
		}
		static void	construct( pointer p, const value_type& value )
		{
			new((void*)p)value_type(value);
		}
		static void	destroy( pointer p )
		{
            UNREFERENCED_PARAMETER( p );        // needed to shut up VC 2010
			p->~TObj();
		}
		void	deallocate( pointer p, size_t /* num */ )
		{
			if( p != 0 ) {
				::CoTaskMemFree( p );
            }
		}

		pointer	p_data_;
		size_t	size_;
		size_t	reserved_;
	};

    template<class T>
    std::vector<T> to_vector( const dvector<T>& v )
    {
        return std::vector<T>( v.begin(), v.end() );
    }
    template<class T>
    std::vector<smart_ptr<T>> to_vector_move( dvector<smart_ptr<T>>& param )
    {
        std::vector<smart_ptr<T>> rval( param.size() );
        for( size_t idx = 0; idx < rval.size(); ++idx )
        {
            rval[idx].swap( param[idx] );
        }
        param.clear();
        return rval;
    }

    template<class T>
    dvector<T> to_dvector( const std::vector<T>& v )
    {
        return dvector<T>( v.begin(), v.end() );
    }
    template<class T>
    dvector<T> to_dvector_single_item( const T& v )
    {
        dvector<T> tmp;
        tmp.push_back( v );
        return tmp;
    }

    /* This practically moves all elements from param into rval and then clears param. */
    template<class T>
    void to_dvector_move( dvector<smart_ptr<T>>& rval, std::vector<smart_ptr<T>>& param )
    {
        rval.resize( param.size() );
        for( size_t idx = 0; idx < rval.size(); ++idx )
        {
            rval[idx].swap( param[idx] );
        }
        param.clear();
    }

    /* This practically moves all elements from param into rval and then clears param. */
    template<class T,class TIter>
    void to_dvector_move( dvector<smart_ptr<T>>& rval, TIter beg, TIter end )
    {
        rval.resize( std::distance( beg, end ) );
        size_t idx = 0;
        for( TIter iter = beg; iter != end; ++iter, ++idx )
        {
            rval[idx].swap( *iter );
        }
    }
}

#endif // DVECTOR_H_INC_