
#ifndef _FILTERLOADER_H_INC_
#define _FILTERLOADER_H_INC_

#include "FrameFilter.h"
#include "dstring.h"
#include "dvector.h"

namespace _DSHOWLIB_NAMESPACE
{
	/**
	 *	The FilterLoader methods allows you to load frame filters from external DLLs.
	 *
	 *	The FilterLoader loads the frame filters from the ".ftf" filter DLLs in the following directories :
			1) The path where this DLL resides. (tis_udshl_*.dll)
			2) The Application Path or if you called <link>FilterLoader::setLoadPath<link> in the specified
				path.
	 *
	 *	The loaded frame filter factories can be queried by calling getAvailableFrameFilters.
	 *	You can then create a specific filter by calling createFilter with a FilterInfo or
	 *	by specifying the according name.
	 *
	 *	As all methods of this class are static, you can not create instances of this class.
	 */
	class FilterLoader
	{
	public:
		/**
		 *	Internal use only.
		 */
        UDSHL_DEPRECATE_FUNCTION_T_( "FilterLoaded::loadDirectory" )
		UDSHL_EXP_API_ static void		setLoadPath( const dstringw& path );

        /**
         *	Load filter factory DLLs from the specified directory
         */
		UDSHL_EXP_API_ static void		loadDirectory( const dstringw& path );
		UDSHL_EXP_API_ static void		loadDirectory( const dstringw& path, const dstringw& search_pattern );

        /** Directly load a specific FrameFilter DLL.
         * @param path      The path to the file to load and add its filters into the FilterLoader
         * @return true on success, false on error
         */
        UDSHL_EXP_API_ static bool		loadDLL( const dstringw& path );
        /**
		 *	Retrieves a list with the names of the available frame filters.
		 *	To instantiate a filter from this list, call
		 *	<link>createFilter</link>.
		 *	@return A list with FilterInfo objects which describe the available filters.
		 */
		static std::vector<FilterInfo>	getAvailableFrameFilters( tFilterClass filterClass = eFC_ALL )
		{
			return to_vector( getAvailableFrameFilters_( filterClass ) );
		}

		/** Creates an instance of a specified frame filter.
		 * @return 0 when no according filter could be created, otherwise a reference to the newly created filter.
		 */
		UDSHL_EXP_API_
		static smart_com<IFrameFilter>	createFilter( const FilterInfo& fi );

		/** Creates an instance of a specified frame filter.
		 * When module == std::string(), then the loader creates the first filter with the specified name
		 *	ignoring the module.
		 * The look up of the filter name is case-sensitive.
		 * @return 0 when no according filter could be created, otherwise a reference to the newly created filter.
		 */
		UDSHL_EXP_API_
		static smart_com<IFrameFilter>	createFilter( const dstringa& filter_name, const dstringa& module = dstringa() );
		UDSHL_EXP_API_
		static smart_com<IFrameFilter>	createFilter( const dstringw& filter_name, const dstringw& module = dstringw() );
	private:
		UDSHL_EXP_API_
		static dvector<FilterInfo>		getAvailableFrameFilters_( tFilterClass filterClass );

		/**
		 *	Do not create any instances of this class.
		 */
		FilterLoader();
	};
}

#endif