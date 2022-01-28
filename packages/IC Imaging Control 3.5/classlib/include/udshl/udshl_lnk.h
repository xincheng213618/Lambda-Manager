
/** This file checks the compiler version and binds to the udshl library and other libraries needed.
 * To use the link feature you must define the UDSHL_LIB_BASEDIR macro.
 * UDSHL_LIB_BASEDIR must contain the relative path to the lib base directory of imaging control.
 *
 * For example this define is used by the samples :
    #define UDSHL_LIB_BASEDIR "..\..\..\ClassLib\"
 * This is automatically expanded to point to the right file for the build.
 *
 * You can prevent linking with anything by specifying UDSHL_LIB_NO_LINK.
 *
 * This file checks the following defines :
    _MSC_VER	// compiler version, defined by the compiler
 *
 * You may pass UDSHL_LIB_NO_COMPILER_CHECK to prevent the compiler checks.
 * 
 */

#ifndef UDSHL_LNK_H_INC_
#define UDSHL_LNK_H_INC_

#pragma once

#if !defined UDSHL_LIB_DIR
    #if defined UDSHL_LIB_BASEDIR
        #ifdef _DEBUG
            #define UDSHL_LIB_DIR UDSHL_LIB_BASEDIR "debug/"
        #else
            #define UDSHL_LIB_DIR UDSHL_LIB_BASEDIR "release/"
        #endif
    #else 
        #define UDSHL_LIB_DIR ""
    #endif
#endif

#ifndef UDSHL_LIB_NO_COMPILER_CHECK

    #if !defined _MSC_VER
        #error Unknown compiler.version.
    #else
        #if _MSC_VER >= 1200  && _MSC_VER <= 1900
             // (1310) VS2003, (1400) VS2005, (1500) VS2008, (1600) VS2010, (1700) VS2012, (1800) VS2013, (1900) VS2015
        #elif _MSC_VER >= 1910 && _MSC_VER < 1919
            // vc141 / VS2017.*
        #elif _MSC_VER >= 1920 && _MSC_VER < 1930
            // vc141 / VS2019.*
        #else
           // #error Unknown Compiler version. 
            // other maybe newer compiler ...
        #endif
    #endif

    #if defined(_WIN32_WINNT) && (_WIN32_WINNT < 0x0501)
    #	error "This library requires _WIN32_WINNT to be at least 0x0501 (Windows XP)"
    #endif
#endif

// #define UDSHL_NAME_BASE is in libbasedefs.h
#define __UDSHL_LPREFIX(txt)	L##txt
#define _UDSHL_LPREFIX(txt)		__UDSHL_LPREFIX(txt)

#if defined _DEBUG
#	define UDSHL_SUFFIX_CONFIGURATION "d"
#else 
#	define UDSHL_SUFFIX_CONFIGURATION ""
#endif

#if defined _M_AMD64
#	define UDSHL_SUFFIX_PLATFORM "_x64"
#else 
#	define UDSHL_SUFFIX_PLATFORM ""
#endif

#define UDSHL_NAME		UDSHL_NAME_BASE UDSHL_SUFFIX_CONFIGURATION UDSHL_SUFFIX_PLATFORM
#define UDSHL_NAME_W	_UDSHL_LPREFIX(UDSHL_NAME_BASE) _UDSHL_LPREFIX(UDSHL_SUFFIX_CONFIGURATION) _UDSHL_LPREFIX(UDSHL_SUFFIX_PLATFORM)

#define UDSHL_DLL_NAME		UDSHL_NAME ".dll"
#define UDSHL_LIB_NAME		UDSHL_NAME ".lib"
#define UDSHL_DLL_NAME_W	UDSHL_NAME_W L".dll"
#define UDSHL_LIB_NAME_W	UDSHL_NAME_W L".lib"

#if !defined UDSHL_LIB_NO_LINK
    // other libraries sometimes needed by applications using this library
    #include <comdef.h>		// commsupp.lib
    
    #pragma comment ( lib, UDSHL_LIB_DIR UDSHL_LIB_NAME )
#endif

// remove previous defined macro
#undef UDSHL_LIB_DIR

#endif // UDSHL_LNK_H_INC_
