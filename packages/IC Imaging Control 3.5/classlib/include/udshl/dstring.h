
#ifndef DSTRING_H_INC_
#define DSTRING_H_INC_

#include <string>
#include <cstring>      // strlen/strcpy/wcslen/wcscpy

#include "libutil_string.h"
#include "udshl_defs.h"

namespace _DSHOWLIB_NAMESPACE 
{
	class dstringa
	{
	public:
		dstringa() : buf_( NULL ) {}
		dstringa( const char* str, size_t len )
			: buf_( NULL )
		{
			buf_ = init( str, len );
		}

		dstringa( const char* str )
			: buf_( NULL )
		{
			buf_ = init( str, calc_len( str ) );
		}
		dstringa( const std::string& str )
			: buf_( NULL )
		{
			buf_ = init( str.c_str(), str.size() );
		}
		dstringa( const dstringa& str )
			: buf_( NULL )
		{
			buf_ = init( str.buf_, calc_len( str.buf_ ) );
		}
		~dstringa()
		{
            ::CoTaskMemFree( buf_ );
		}

		dstringa& operator=( const dstringa& str )
		{
			dstringa temp( str );
			swap( temp );
			return *this;
		}
		dstringa& operator=( const char* str )
		{
			dstringa temp( str );
			swap( temp );
			return *this;
		}
		void swap( dstringa& str )                  { std::swap( buf_, str.buf_ ); }

		operator std::string()	const	            { return to_string(); }

		const char*		c_str() const			    { return buf_ == NULL ? "" : buf_; }
		bool	        empty() const				{ return buf_ == NULL || buf_[0] == '\0'; }

		std::string	    to_string() const	        { return  std::string( buf_ == NULL ? "" : buf_ ); }

		bool	operator==( const std::string& rhs ) const { return to_string() == rhs; }
		bool	operator!=( const std::string& rhs ) const { return to_string() != rhs; }
	private:
		static size_t		calc_len( const char* str )
		{
            if( str == NULL ) return 0;
			
            return strlen( str );
		}
		static char*		init( const char* str, size_t str_len )
		{
            if( str == NULL || str_len == 0 )
            {
                return NULL;
            }

			char* buf = static_cast<char*>( CoTaskMemAlloc( (str_len + 1) * sizeof( str[0] ) ) );
			if( !buf ) {
				throw std::bad_alloc();
			}
#pragma warning( suppress : 4996 )
            strcpy( buf, str );
            buf[str_len] = 0;
			return buf;
		}
		char*		buf_;
	};

	inline bool	operator<( const dstringa& lhs, const dstringa& rhs )
	{
		return lhs.to_string() < rhs.to_string();
	}

	class dstringw
	{
	public:
		dstringw() : buf_( NULL ) {}
		dstringw( const wchar_t* str, size_t len )
			: buf_( NULL )
		{
			buf_ = init( str, len );
		}

		dstringw( const wchar_t* str )
			: buf_( NULL )
		{
			assert( str );
			buf_ = init( str, calc_len( str ) );
		}
		dstringw( const std::wstring& str )
			: buf_( NULL )
		{
			buf_ = init( str.c_str(), str.size() );
		}

		dstringw( const dstringw& str )
			: buf_( NULL )
		{
			buf_ = init( str.buf_, calc_len( str.buf_ ) );
		}

		~dstringw()
		{
            ::CoTaskMemFree( buf_ );
		}

		dstringw& operator=( const dstringw& str )
		{
			dstringw temp( str );
			swap( temp );
			return *this;
		}
		dstringw& operator=( const wchar_t* str )
		{
			dstringw temp( str );
			swap( temp );
			return *this;
		}


        void swap( dstringw& str ) { std::swap( buf_, str.buf_ ); }

        operator std::wstring()	const { return to_string(); }

        const wchar_t*	c_str() const { return buf_ == NULL ? L"" : buf_; }
        bool	        empty() const { return buf_ == NULL || buf_[0] == L'\0'; }

        std::wstring	to_string() const { return std::wstring( buf_ == NULL ? L"" : buf_ ); }

        bool	operator==( const std::wstring& rhs ) const { return to_string() == rhs; }
        bool	operator!=( const std::wstring& rhs ) const { return to_string() != rhs; }
	private:
		static size_t		calc_len( const wchar_t* str )
		{
            if( str == NULL ) return 0;
			return wcslen( str );
		}
		static wchar_t*		init( const wchar_t* str, size_t str_len )
        {
            if( str == NULL || str_len == 0 )
            {
                return NULL;
            }
			wchar_t* buf = static_cast<wchar_t*>( CoTaskMemAlloc( (str_len + 1) * sizeof( wchar_t ) ) );
			if( !buf ) {
				throw std::bad_alloc();
			}
#pragma warning( suppress : 4996 )
            wcscpy( buf, str );
            buf[str_len] = 0;
            return buf;
		}

		wchar_t*		buf_;
	};

	inline bool	operator<( const dstringw& lhs, const dstringw& rhs )
	{
		return lhs.to_string() < rhs.to_string();
	}
};

#endif // DSTRING_H_INC_
