
#ifndef MEDIASTREAMCONTAINER_H_INC_
#define MEDIASTREAMCONTAINER_H_INC_

#pragma once

#include <string>
#include <vector>
#include "udshl_defs.h"
#include "smart_com.h"
#include "smart_ptr.h"

#include "int_interface_pre.h"

#include "dstring.h"
#include "dvector.h"

namespace _DSHOWLIB_NAMESPACE
{
	class MediaStreamSink;
	class MediaStreamContainer;
	class Codec;

	typedef smart_ptr<MediaStreamContainer>			tMediaStreamContainerPtr;
	typedef std::vector<tMediaStreamContainerPtr>	tMediaStreamContainerList;
	typedef smart_ptr<tMediaStreamContainerList>	tMediaStreamContainerListPtr;

	UDSHL_EXP_API_ extern const GUID MSC_AviContainer;
	UDSHL_EXP_API_ extern const GUID MSC_OGMContainer;
	UDSHL_EXP_API_ extern const GUID MSC_MatroskaContainer;

	/** This class represents a media stream container, which represents the container destination for
	 * media streams.
	 * Standard container types are "AVI" or "OGM".
	 */
	class MediaStreamContainer
	{
		friend MediaStreamSink;
	public:
		UDSHL_EXP_API_ ~MediaStreamContainer();

		/** Returns a list of available container types.
		 * @return May be 0 when a critical error occurred. May be empty (size() == 0) when no containers were found.
		 *			Otherwise contains the available containers as present in the system.
		 */
		UDSHL_DEPRECATE_FUNCTION_T_("getAvailableMediaStreamContainerList function" )
		static tMediaStreamContainerListPtr	getAvailableMediaStreamContainers()
		{
			dvector<smart_ptr<MediaStreamContainer> > rval = getAvailableMediaStreamContainers_();
			return new tMediaStreamContainerList( rval.begin(), rval.end() );
		}
		/** Returns a list of available container types.
		 * @return Contains the containers as present in the system.
		 */
        static tMediaStreamContainerList	getAvailableMediaStreamContainerList()
        {
            dvector<smart_ptr<MediaStreamContainer> > rval = getAvailableMediaStreamContainers_();
            return tMediaStreamContainerList( rval.begin(), rval.end() );
        }

		/** Creates the container specified with the id.
		 * @param id The container id of the container.
		 * @return 0 when the container could not be found/created, otherwise a reference to the container.
		 */
		UDSHL_EXP_API_ static tMediaStreamContainerPtr		create( const GUID& id );

		/** This creates a copy of the stream container, which is completely independent from the
		 * current object, but copies the internal state and data of the container.
		 * @return
		 */
		UDSHL_EXP_API_ tMediaStreamContainerPtr	            clone() const;

		/**	Returns a reference to an internal interface.
		* With this function you can fetch an custom interface from the codec.
		* To use this function your compiler must support the __uuidof operator and the interface must
		* be assigned an iid with the __declspec( uuid( "iid" ) ) compiler option. When this option is
		* not available then you should use the other function.
		* \param pItf
		* \return A reference to the interface requested or 0 if the interface is not supported.
		*/
		template<class TItf>
		smart_com<TItf>		getInternalInterface( smart_com<TItf>& pItf ) const
		{
			return getInternalInterface( __uuidof( TItf ), pItf );
		}

		/**	Returns a reference to an internal interface.
		* With this function you can fetch an custom interface from the codec.
		* \par usage
		*
		*	smart_com<ICodecInterface> pItf;
		*	if( pFilterInfoObject->getInternalInterface( pItf ) == 0 )
		*	{
		*		... // interface is not supported, so error handling
		*	}
		*	else
		*	{
		*		...	// use the interface
		*	}
		*
		* \param pItf A smart_com to a interface reference.
		* \param riid An interface ID.
		* \return A reference to the interface requested or 0 if the interface is not supported.
		*/
		template<class TItf>
		smart_com<TItf>		getInternalInterface( REFIID riid, smart_com<TItf>& pItf ) const
		{
			pItf = 0;
			getInternalInterface_( riid, (void**) &pItf.get() );
			return pItf;
		}

		/** The string representation of this container. */
		std::string		getDescription() const { return toString(); }
		std::wstring	getDescriptionW() const { return toStringW(); }
		/** The string representation of this container. */
		std::string		toString() const { return wstoas( toString_() ); }
		std::wstring	toStringW() const { return toString_(); }

		UDSHL_EXP_API_ bool			operator==( const dstringa& ) const;
		UDSHL_EXP_API_ bool			operator==( const dstringw& ) const;

		/** Returns the unique container ID, which you can use to create the container without referring to
		 * the description string.
		 */
		UDSHL_EXP_API_ GUID			getMediaStreamContainerID() const;

		/** Returns if this container does support any codec. Certain container types do not support any codecs at all.
		 */
		UDSHL_EXP_API_ bool			isCustomCodecSupported() const;

		/** Returns if this MediaStreamContainer supports this specific codec. If yes then you can create a new MediaStreamSink sink
		 * with this container and Codec combination.
		 * Certain container/codec combinations do not work.
		 */
		UDSHL_EXP_API_ bool			isCustomCodecSupported( const smart_ptr<Codec>& codec ) const;

		/** Returns if this MediaStreamContainer supports this specific codec. If yes then you can create a new MediaStreamSink sink
		 * with this container and Codec combination.
		 * Certain container/codec combinations do not work.
		 */
        UDSHL_EXP_API_ bool			isUncompressedSupported() const;

		/** Returns the standard file extension used by this container.
		 * e.g. "avi" for AVI files.
		 * @return The file extension.
		 */
		std::string		getPreferredFileExtension() const { return wstoas( getPreferredFileExtension_() ); }
		std::wstring	getPreferredFileExtensionW() const { return getPreferredFileExtension_(); }
	private:
		UDSHL_EXP_API_ dstringw		getPreferredFileExtension_() const;
		UDSHL_EXP_API_ dstringw		toString_() const;

		MediaStreamContainer( const MediaStreamContainer& );

		MediaStreamContainer&	operator=( const MediaStreamContainer& );

		MediaStreamContainer( const smart_com<icbase::IDShowFactoryObjectInfo>& pF );
		MediaStreamContainer( const smart_com<icbase::IDShowFactoryObjectInfo>& pInfo,  const smart_com<icbase::IDShowFilter>& pF );

		UDSHL_EXP_API_ HRESULT			getInternalInterface_( REFIID riid, void** ppv ) const;

        UDSHL_EXP_API_ static dvector<smart_ptr<MediaStreamContainer> >	getAvailableMediaStreamContainers_();

		smart_com<icbase::IDShowFilter>				getFilter() const;

		mutable smart_com<icbase::IDShowFilter>				m_pFWFilter;
		mutable smart_com<icbase::IDShowFactoryObjectInfo>	m_pFWFilterInfo;
	};
}

#endif // MEDIASTREAMCONTAINER_H_INC_
