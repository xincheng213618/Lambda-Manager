#ifndef LIBUTIL_STRING_H_INC_
#define LIBUTIL_STRING_H_INC_

#pragma once

#include <string>
#include "libbasedefs.h"

namespace _DSHOWLIB_NAMESPACE
{
	/**	wide string to ascii string
	* \param op the wide input string
	* \param rval temporary ascii string
	* \return the resulting ascii string
	*/
	std::string			wstoas( const std::wstring& op );

	/**	ascii string to wide string
	* \param op the ascii input string
	* \param rval temporary wide string
	* \return the resulting wide string
	*/
	std::wstring		astows( const std::string& op );

	/** GUID <-> String conversion functions
	*/
	GUID			StringToGUID( const wchar_t* pString );
	std::wstring	GUIDToWString( const GUID& id );

	inline	std::string	wstoas( const std::wstring& ws )
	{
        size_t reqLength = ::WideCharToMultiByte( CP_UTF8, 0, ws.c_str(), int( ws.length() ), 0, 0, 0, 0 );
        if( reqLength == 0 ) return std::string();

        std::string ret( reqLength, '\0' );
        ::WideCharToMultiByte( CP_UTF8, 0, ws.c_str(), int( ws.length() ), &ret[0], int( ret.length() ), 0, 0 );

        return ret;
    }

	inline std::wstring astows( const std::string& as )
	{
        size_t reqLength = ::MultiByteToWideChar( CP_UTF8, 0, as.c_str(), int( as.length() ), 0, 0 );
        if( reqLength == 0 ) return std::wstring();

        std::wstring ret( reqLength, L'\0' );
        ::MultiByteToWideChar( CP_UTF8, 0, as.c_str(), int( as.length() ), &ret[0], int( ret.length() ) );
        return ret;
	}


	inline GUID			StringToGUID( const wchar_t* pString )
	{
		GUID id = GUID_NULL;
		if( FAILED(::CLSIDFromString(const_cast<wchar_t*>(pString), &id) ) )
		{
			return GUID_NULL;
		}
		return id;
	}

	inline std::wstring		GUIDToWString( const GUID& id )
	{
		wchar_t* pStr = 0;
		std::wstring rval;
		HRESULT hr = ::StringFromCLSID( id, &pStr );
		if( SUCCEEDED( hr ) && pStr != NULL )
		{
			rval = pStr;
		}
        ::CoTaskMemFree( pStr );
        return rval;
	}
    inline BSTR			GUIDToBSTR( const GUID& id )
    {
        std::wstring tmp = GUIDToWString( id );
        return ::SysAllocString( tmp.c_str() );
    }
}

#endif // LIBUTIL_STRING_H_INC_
