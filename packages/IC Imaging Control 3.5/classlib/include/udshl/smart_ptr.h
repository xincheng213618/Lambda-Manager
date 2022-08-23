#ifndef SMARTPTR_H_INC_
#define SMARTPTR_H_INC_

#include <windows.h>


// forward declarations
template<typename TType> class smart_ptr;

class refcount_ptr_base
{
public:
    refcount_ptr_base() : ref_count_( 1 )   {}
    virtual ~refcount_ptr_base()            {}

    LONG		AddRef() { return InterlockedIncrement( &ref_count_ ); }
    LONG		Release()
    {
        LONG val = ::InterlockedDecrement( &ref_count_ );
        if( val == 0 )
        {
            delete_self_();
            return 0;
        }
        return val;
    }
    virtual void delete_self_() = 0;
private:
    LONG			ref_count_;
};

template<typename TType>
class smart_ptr
{
private:
    template<class T>
    class refcount_ptr : public refcount_ptr_base
    {
    public:
        refcount_ptr( T* p ) : data_( p ) {}
        ~refcount_ptr() { delete data_; }

        virtual void delete_self_() { delete this; }
    private:
        T*				data_;
    };

    template<class Ty0>
    friend class smart_ptr;
public:
    typedef TType			value_type;
    typedef TType*			pointer;
    typedef const TType*	const_pointer;

    typedef smart_ptr<TType>	object_type;
public:
    smart_ptr() : ptr_( NULL ), ref_( NULL ) {}
    smart_ptr( TType* p ) : ptr_( p ), ref_( NULL )
    {
        if( p != NULL )
        {
            ref_ = new refcount_ptr<TType>( p );
        }
    }
    smart_ptr( TType* p, refcount_ptr_base* ref, bool attach = false )
        : ptr_( p ), ref_( ref )
    {
        if( ref_ != NULL && !attach )
        {
            ref_->AddRef();
        }
    }

    template<typename Top2>
    smart_ptr( TType* p, const smart_ptr<Top2>& refcount_type )
        : ptr_( p ), ref_( refcount_type.ref_ )
    {
        if( ref_ != NULL )
        {
            ref_->AddRef();
        }
    }

    template<typename TTOp2>
    smart_ptr( const smart_ptr<TTOp2>& op2 )
        : ptr_( op2.ptr_ ), ref_( op2.ref_ )    // If this line breaks with an error in your compiler, you most likely have to use static_smart_ptr_cast<TTOp2>( op2 )
    {
        if( ref_ != NULL )
        {
            ref_->AddRef();
        }
    }

    /** copy constructor */
    smart_ptr( const smart_ptr& op2 ) : ptr_( op2.ptr_ ), ref_( op2.ref_ )
    {
        if( ref_ != NULL )
        {
            ref_->AddRef();
        }
    }

#if defined UDSHL_HAS_CXX_MOVE_
    smart_ptr( smart_ptr&& op2 ) : ptr_( op2.ptr_ ), ref_( op2.ref_ )
    {
        op2.ref_ = NULL;
        op2.ptr_ = NULL;
    }
    smart_ptr&  operator=( smart_ptr&& op2 )
    {
        destroy();
        swap( op2 );
        return *this;
    }
#endif

    /** dtor */
    ~smart_ptr()
    {
        if( ref_ != NULL ) {
            ref_->Release();
        }
        ref_ = NULL;
        ptr_ = NULL;
    }
    
    /** assignment operator*/
    smart_ptr&	operator=( const smart_ptr& op2 )
    {
        smart_ptr tmp( op2 );
        tmp.swap( *this );
        return *this;
    }

    TType&			    operator*() { return *get(); }
    const TType&		operator*() const { return *get(); }
    pointer				operator->() { return get(); }
    const_pointer		operator->() const { return get(); }

    bool		operator==( const smart_ptr& op2 ) const { return get() == op2.get(); }
    bool		operator!=( const smart_ptr& op2 ) const { return get() != op2.get(); }

    bool		operator==( const pointer p ) const { return get() == p; }
    bool		operator!=( const pointer p ) const { return get() != p; }

    /** lets you get the internal pointer representation
     * <strong>do not delete the internal rep, use destroy</strong>
     */
    pointer			get() { return ptr_; }

    /** lets you get the internal pointer representation
     * <strong>do not delete the internal rep, use destroy</strong>
     */
    const_pointer	get() const { return ptr_; }

    /** destroys the internal reference and sets this to zero */
    void			destroy() { reset(); }

    /** swaps this with op2 */
    void			swap( smart_ptr& op2 ) { std::swap( ref_, op2.ref_ ); std::swap( ptr_, op2.ptr_ ); }

    void            reset()             { smart_ptr tmp; swap( tmp ); }
    void            reset( pointer p )  { smart_ptr tmp( p ); swap( tmp ); }
private:
    TType*                      ptr_;
    mutable refcount_ptr_base*	ref_;
};

template<typename TDestType,typename TType>
inline smart_ptr<TDestType>	static_smart_ptr_cast( smart_ptr<TType> op2 )
{
    return smart_ptr<TDestType>( static_cast<TDestType*>( op2.get() ), op2 );
}

template<typename TType>
inline bool		operator==( const void* p, const smart_ptr<TType>& op2 )
{
    return op2.get() == p;
}

template<typename TType>
inline bool		operator!=( const void* p, const smart_ptr<TType>& op2 )
{
    return op2.get() != p;
}

template<typename TType>
inline void	swap( smart_ptr<TType>& op1, smart_ptr<TType>& op2 ) { op1.swap( op2 ); }

#endif