// Error.h: interface for the Error class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_ERROR_H__6EB4029E_C2A2_4353_8938_FF398FE42826__INCLUDED_)
#define AFX_ERROR_H__6EB4029E_C2A2_4353_8938_FF398FE42826__INCLUDED_

#pragma once

#include <string>
#include "udshl_defs.h"
#include "simplectypes.h"

#include "int_interface_pre.h"
#include "dstring.h"

namespace _DSHOWLIB_NAMESPACE
{
	/** The Error class gives information about an error occurred during a call to the class library.
	 *
	 * Example usage :
	 * <br><code>
		Grabber g;
		// ...
		if( !g.startLive() )
		{
			Error e = g.getLastError();
			if( e.getVal() == eDEVICE_INVALID )
			{
				MessageBox( "Device has become invalid.", ... );
				// reopen device
			}
			else
			{
				MessageBox( e.toString(), ... );
				exit( -1 );
			}
		}
	   </code>
	 **/
	class Error 
	{
	public:
		/** Constructs an unknown (eUNKNOWN)!!!! Error **/
        Error() : error_value_( eUNKNOWN )        {}
        Error( const Error& e ) : error_value_( e.error_value_ ), additional_string_value_( e.additional_string_value_ ) {}
        /** Constructs an unknown error with given message
         * @param errordesc description of the error
         **/
        UDSHL_DEPRECATE_FUNCTION_
        Error( const dstringa& errordesc ) : error_value_( eUNKNOWN ), additional_string_value_( astows( errordesc ) ) {}
        UDSHL_DEPRECATE_FUNCTION_
        Error( const dstringw& errordesc ) : error_value_( eUNKNOWN ), additional_string_value_( ( errordesc ) ) {}

        ~Error()    {}

        Error&  operator=( const Error& err ) { error_value_ = err.error_value_; additional_string_value_ = err.additional_string_value_; return *this; }

		/** constructs an error with given error code and uses the string from the resources
		 * @param e error code
		 **/
        Error( tErrorEnum e ) : error_value_( e ) {}

		/** return a string representation for the error
		 * @return a string representation for the error
		 **/
        UDSHL_DEPRECATE_FUNCTION_T_( "Error::toString()" )
		std::string		getString() const   { return toString(); }
        UDSHL_DEPRECATE_FUNCTION_T_( "Error::toStringW()" )
        std::wstring	getStringW() const { return toStringW(); }
        /** return a string representation for the error
		 * @return a string representation for the error
		 **/
		std::string		toString() const    { return wstoas( toString_() ); }
        /** return a string representation for the error
         * @return a string representation for the error
         **/
        std::wstring	toStringW() const   { return toString_(); }

		/** return the error code of the error
		 * @return the error code of the error
		 **/
		tErrorEnum	    getVal() const      { return error_value_; }

		/** return true, if the internal error value equals not eNOERROR
		 * @return true, if the internal error value equals not eNOERROR
		 **/
		bool	        isError() const             { return eNOERROR != error_value_; }
        bool            isSuccess() const           { return !isError(); }

        static UDSHL_EXP_API_  Error    to_error( const icbase::IDShowError& e );
		static UDSHL_EXP_API_  Error    to_error( tErrorEnum err, const dstringw& str );
	private: // members
        UDSHL_EXP_API_  dstringw		toString_() const;

        Error( tErrorEnum err, const dstringw& errordesc ) : error_value_( err ), additional_string_value_( errordesc ) {}

        tErrorEnum	    error_value_;
		dstringw	    additional_string_value_;
	};
}

#endif // !defined(AFX_ERROR_H__6EB4029E_C2A2_4353_8938_FF398FE42826__INCLUDED_)
