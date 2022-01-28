
#ifndef UDSHL_DEFS_H_INC
#define UDSHL_DEFS_H_INC

#include "libbasedefs.h"

#if defined _MSC_VER && _MSC_VER < 1600

// introduce the C99/C++11 defines for basic width types
typedef signed char        int8_t;
typedef short              int16_t;
typedef int                int32_t;
typedef long long          int64_t;
typedef unsigned char      uint8_t;
typedef unsigned short     uint16_t;
typedef unsigned int       uint32_t;
typedef unsigned long long uint64_t;

#else
#include <cstdint>
#endif

#if !defined UDSHL_EXP_API_
#if defined UDSHL_GENERATE_DLL_EXPORTS
	#define UDSHL_EXP_API_	__declspec(dllexport)
#else
    #define UDSHL_EXP_API_	__declspec(dllimport)
#endif
#endif

#define UDSHL_LIB_VERSION_MAJOR	3
#define UDSHL_LIB_VERSION_MINOR	5

#if !defined UDSHL_DISABLE_DEPRECATE_MESSAGES_ && defined UDSHL_GENERATE_DLL_EXPORTS
#define UDSHL_DISABLE_DEPRECATE_MESSAGES_
#endif

// use UDSHL_DEPRECATE_FUNCION_DISABLE_ to disable deprecation
#if _MSC_VER > 1500 && !defined UDSHL_DISABLE_DEPRECATE_MESSAGES_
#define UDSHL_DEPRECATE_FUNCTION_	__declspec(deprecated)
#define UDSHL_DEPRECATE_FUNCTION_TEXT_(text)	__declspec(deprecated(text))
// Text generated is: "was declared deprecated. Instead, use the <replacement>."
#define UDSHL_DEPRECATE_FUNCTION_T_(replacement)       __declspec(deprecated("was declared deprecated. Instead, use the " replacement "."))
#define UDSHL_DEPRECATE_MESSAGES_ENABLED_   1
#else
#define UDSHL_DEPRECATE_FUNCTION_
#define UDSHL_DEPRECATE_FUNCTION_TEXT_(text)
#define UDSHL_DEPRECATE_FUNCTION_T_(replacement)
#endif

#if !defined UDSHL_HAS_CXX_MOVE_ && !defined UDSHL_DISABLE_CXX_MOVE_

// This enables move operations for some inline code in the library. IF your compiler does not have std::move, disable this via defining UDSHL_DISABLE_CXX_MOVE_

#  if defined _MSC_VER && _MSC_VER >= 1600 
#    define UDSHL_HAS_CXX_MOVE_ 
#  elif !defined _MSC_VER
#    define UDSHL_HAS_CXX_MOVE_
#  endif
#endif

#endif // UDSHL_DEFS_H_INC