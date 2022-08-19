
#ifndef MEDIASTREAMSINK_H_INC_
#define MEDIASTREAMSINK_H_INC_

#pragma once

#include <string>
#include "udshl_defs.h"
#include "smart_ptr.h"

#include "int_interface_pre.h"

#include "GrabberSinkType.h"
#include "Codec.h"
#include "MediaStreamContainer.h"

#include "FrameFilter.h"

namespace _DSHOWLIB_NAMESPACE
{
	class MediaStreamSink;

	typedef smart_ptr<MediaStreamSink>		tMediaStreamSinkPtr;

	/** The MediaStreamSink can be used to create streamable content. By using a specified MediaStreamContainer
	 * you can should the container for the image stream. These can be avi, ogm or matroska files. Other stream
	 * containers can be supplied later. When a codec or subtype is supplied, the frames inserted into the
	 * container are encoded to this type.
	 * With this kind of customization you can create a avi file with uncompressed RGB32 images.
	 */
	class MediaStreamSink : public GrabberSinkType  
	{
	public:
		typedef tMediaStreamSinkPtr			tMSSPtr;
		typedef tMediaStreamContainerPtr	tMSCPtr;

		struct tCreateData
		{
			tCreateData( const tMSCPtr& pCont, IFrameFilter* pCB = 0 );
			tCreateData( const tMSCPtr& pCont, const GUID& subtype, IFrameFilter* pCB = 0 );
			tCreateData( const tMSCPtr& pCont, const smart_ptr<Codec>& pFIO, IFrameFilter* pCB = 0 );
			tCreateData( const tMSCPtr& pCont, const tFrameFilterList& lst );
			tCreateData( const tMSCPtr& pCont, const GUID& subtype, const tFrameFilterList& lst );
			tCreateData( const tMSCPtr& pCont, const smart_ptr<Codec>& pFIO, const tFrameFilterList& lst );

			tCreateData( const GUID& cont_id, IFrameFilter* pCB = 0 );
			tCreateData( const GUID& cont_id, const GUID& subtype, IFrameFilter* pCB = 0 );
			tCreateData( const GUID& cont_id, const smart_ptr<Codec>& pFIO, IFrameFilter* pCB = 0 );
			tCreateData( const GUID& cont_id, const tFrameFilterList& lst );
			tCreateData( const GUID& cont_id, const GUID& subtype, const tFrameFilterList& lst );
			tCreateData( const GUID& cont_id, const smart_ptr<Codec>& pFIO, const tFrameFilterList& lst );

			tCreateData& operator=( const tCreateData& op2 );

			tMSCPtr							m_pContainer;
			GUID							m_ContainerID;
			smart_ptr<Codec>				m_pCodec;
			GUID							m_Subtype;
			dvector<IFrameFilter*>			m_filterChain;

			tFrameFilterList				getFilterChain() const { return to_vector( m_filterChain ); }
		};

		/** These functions create a complete and independent sink, which uses the MediaStreamContainer and the 
		 * Codec passed in. These objects should not be used in any other MediaStreamSink.
		 */
		UDSHL_EXP_API_ static tMSSPtr	create( const tCreateData& create_data );
		UDSHL_EXP_API_ static tMSSPtr	create( const tMSCPtr& pCont, IFrameFilter* pFrameCB = 0 );
		UDSHL_EXP_API_ static tMSSPtr	create( const tMSCPtr& pCont, const smart_ptr<Codec>& pCodec, IFrameFilter* pFrameCB = 0 );
		UDSHL_EXP_API_ static tMSSPtr	create( const tMSCPtr& pCont, const GUID& subtype, IFrameFilter* pFrameCB = 0 );
		UDSHL_EXP_API_ static tMSSPtr	create( const tMSCPtr& pCont, const dvector<IFrameFilter*>& lst );
		UDSHL_EXP_API_ static tMSSPtr	create( const tMSCPtr& pCont, const smart_ptr<Codec>& pCodec, const dvector<IFrameFilter*>& lst );
		UDSHL_EXP_API_ static tMSSPtr	create( const tMSCPtr& pCont, const GUID& subtype, const dvector<IFrameFilter*>& lst );
		inline static tMSSPtr	create( const tMSCPtr& pCont, const tFrameFilterList& lst )
		{
			return create( pCont, dvector<IFrameFilter*>( lst.begin(), lst.end() ) );
		}
		inline static tMSSPtr	create( const tMSCPtr& pCont, const smart_ptr<Codec>& pCodec, const tFrameFilterList& lst )
		{
			return create( pCont, pCodec, dvector<IFrameFilter*>( lst.begin(), lst.end() ) );
		}
		inline static tMSSPtr	create( const tMSCPtr& pCont, const GUID& subtype, const tFrameFilterList& lst )
		{
			return create( pCont, subtype, dvector<IFrameFilter*>( lst.begin(), lst.end() ) );
		}

		UDSHL_EXP_API_ static tMSSPtr	create( const GUID& cont_id, IFrameFilter* pCB = 0 );
		UDSHL_EXP_API_ static tMSSPtr	create( const GUID& cont_id, const GUID& subtype, IFrameFilter* pCB = 0 );
		UDSHL_EXP_API_ static tMSSPtr	create( const GUID& cont_id, const smart_ptr<Codec>& pFIO, IFrameFilter* pCB = 0 );
		UDSHL_EXP_API_ static tMSSPtr	create( const GUID& cont_id, const dvector<IFrameFilter*>& lst );
		UDSHL_EXP_API_ static tMSSPtr	create( const GUID& cont_id, const smart_ptr<Codec>& pCodec, const dvector<IFrameFilter*>& lst );
		UDSHL_EXP_API_ static tMSSPtr	create( const GUID& cont_id, const GUID& subtype, const dvector<IFrameFilter*>& lst );
		inline static tMSSPtr	create( const GUID& cont_id, const tFrameFilterList& lst )
		{
			return create( cont_id, dvector<IFrameFilter*>( lst.begin(), lst.end() ) );
		}
		inline static tMSSPtr	create( const GUID& cont_id, const smart_ptr<Codec>& pCodec, const tFrameFilterList& lst )
		{
			return create( cont_id, pCodec, dvector<IFrameFilter*>( lst.begin(), lst.end() ) );
		}
		inline static tMSSPtr	create( const GUID& cont_id, const GUID& subtype, const tFrameFilterList& lst )
		{
			return create( cont_id, subtype, dvector<IFrameFilter*>( lst.begin(), lst.end() ) );
		}

		/** dtor */
		UDSHL_EXP_API_ ~MediaStreamSink();

		/** always returns eMediaStreamSink
		 * @return eMediaStreamSink or one derived sink
		 */
		UDSHL_EXP_API_ tSinkType		getSinkType() const;

		/** Sets a new filename.
		 * @param str The new filename.
		 * @return true on success, false if the sink is already streaming.
		 */
		UDSHL_EXP_API_ bool				setFilename( const dstringa& str ) const;
		UDSHL_EXP_API_ bool				setFilename( const dstringw& str ) const;


		/** The filename which was set by the user for this sink */
		std::string				    getFilename() const { return wstoas( getFilename_() ); }
		/** The filename which was set by the user for this sink */
		std::wstring				getFilenameW() const { return getFilename_(); }

		/** Returns the codec used for this sink.
		 * @return Either the according codec, or 0 if no codec is used.
		 */
		UDSHL_EXP_API_ virtual smart_ptr<Codec>	getCodec() const;
		UDSHL_EXP_API_ virtual tMSCPtr			getContainer() const;

		/** Returns the subtype of the uncompressed video
		 * @return Either the GUID of the uncompressed format or GUID_NULL 
		 * if uncompressed is not used.
		 */
		UDSHL_EXP_API_ virtual GUID			getSubType() const;

		/** This sets a IFrameFilter handler which can act as a sink spy or gate.
		 * You can not set the handler when the sink is attached and the stream is running.
		 *
		 * @return true on success, false when the stream is already running.
		 */
		UDSHL_EXP_API_ bool					setFrameFilter( IFrameFilter* pCB );
		UDSHL_EXP_API_ bool					setFrameFilter_( const dvector<IFrameFilter*>& lst );

		bool					setFrameFilter( const tFrameFilterList& lst )
		{
			return setFrameFilter_( dvector<IFrameFilter*>( lst.begin(), lst.end() ) );
		}
		/** Returns the currently set IFrameFilter handler. This may be 0 when no handler was set. */
		const tFrameFilterList	getFrameFilters() const { return to_vector( getFrameFilters_() ); }

		/** Returns the tCreateData structure which holds the information used to create this sink. */
		UDSHL_EXP_API_ const tCreateData&		getCreateData() const;


		/**
		*	Enables or disables frame time correction:
		*		Enabled	=	dropped frames are removed from the video stream, and the frame times
		*					of the later frames are adjusted just as if the dropped frames never
		*					existed
		*		Disabled =	Do not alter the frame times, the result is that a recorded AVI file
		*					will contain still images where frames are dropped
		*/
		UDSHL_EXP_API_ void	setFrameTimeCorrection( bool bEnabled );
		UDSHL_EXP_API_ bool	getFrameTimeCorrection();

	protected:
		UDSHL_EXP_API_ dvector<IFrameFilter*>	getFrameFilters_() const;
		UDSHL_EXP_API_ dstringw			        getFilename_() const;

        virtual bool	attach( GrabberPImpl* );
        virtual void	detach();

		MediaStreamSink( const tCreateData& cont );

		MediaStreamSink( const MediaStreamSink& );
		MediaStreamSink& operator=( const MediaStreamSink& cont );

		tCreateData							m_Data;

		smart_com<icbase::IDShowFilter>		m_pSinkFilter;
		smart_com<IFrameFilter>				m_pFilterChain;

		virtual smart_com<icbase::IDShowFilter>		getBaseSinkFilter() const;
	};


	inline MediaStreamSink::tCreateData::tCreateData( const tMSCPtr& pCont, IFrameFilter* pCB )
		: m_pContainer( pCont ), m_ContainerID( GUID_NULL ), m_pCodec( 0 ), m_Subtype( GUID_NULL )
	{
		if( pCB != 0 ) {
			m_filterChain.push_back( pCB );
		}
	}

	inline MediaStreamSink::tCreateData::tCreateData( const tMSCPtr& pCont, const smart_ptr<Codec>& pFIO, IFrameFilter* pCB )
		: m_pContainer( pCont ), m_ContainerID( GUID_NULL ),m_pCodec( pFIO ), m_Subtype( GUID_NULL )
	{
		if( pCB != 0 ) {
			m_filterChain.push_back( pCB );
		}
	}

	inline MediaStreamSink::tCreateData::tCreateData( const tMSCPtr& pCont, const GUID& subtype, IFrameFilter* pCB )
		: m_pContainer( pCont ), m_ContainerID( GUID_NULL ),m_pCodec( 0 ), m_Subtype( subtype )
	{
		if( pCB != 0 ) {
			m_filterChain.push_back( pCB );
		}
	}

	inline MediaStreamSink::tCreateData::tCreateData( const tMSCPtr& pCont, const tFrameFilterList& lst )
		: m_pContainer( pCont ), m_ContainerID( GUID_NULL ), m_pCodec( 0 ), m_Subtype( GUID_NULL ), m_filterChain( lst.begin(), lst.end() )
	{
	}

	inline MediaStreamSink::tCreateData::tCreateData( const tMSCPtr& pCont, const smart_ptr<Codec>& pFIO, const tFrameFilterList& lst )
		: m_pContainer( pCont ), m_ContainerID( GUID_NULL ),m_pCodec( pFIO ), m_Subtype( GUID_NULL ), m_filterChain( lst.begin(), lst.end() )
	{
	}

	inline MediaStreamSink::tCreateData::tCreateData( const tMSCPtr& pCont, const GUID& subtype, const tFrameFilterList& lst )
		: m_pContainer( pCont ), m_ContainerID( GUID_NULL ),m_pCodec( 0 ), m_Subtype( subtype ), m_filterChain( lst.begin(), lst.end() )
	{
	}


	inline MediaStreamSink::tCreateData::tCreateData( const GUID& cont_id, IFrameFilter* pCB )
		: m_pContainer( 0 ), m_ContainerID( cont_id ), m_pCodec( 0 ), m_Subtype( GUID_NULL )
	{
		if( pCB != 0 ) {
			m_filterChain.push_back( pCB );
		}
	}

	inline MediaStreamSink::tCreateData::tCreateData( const GUID& cont_id, const smart_ptr<Codec>& pFIO, IFrameFilter* pCB )
		: m_pContainer( 0 ), m_ContainerID( cont_id ),m_pCodec( pFIO ), m_Subtype( GUID_NULL )
	{
		if( pCB != 0 ) {
			m_filterChain.push_back( pCB );
		}
	}


	inline MediaStreamSink::tCreateData::tCreateData( const GUID& cont_id, const GUID& subtype, IFrameFilter* pCB )
		: m_pContainer( 0 ), m_ContainerID( cont_id ),m_pCodec( 0 ), m_Subtype( subtype )
	{
		if( pCB != 0 ) {
			m_filterChain.push_back( pCB );
		}
	}

	inline MediaStreamSink::tCreateData::tCreateData( const GUID& cont_id, const tFrameFilterList& lst )
		: m_pContainer( 0 ), m_ContainerID( cont_id ),m_pCodec( 0 ), m_Subtype( GUID_NULL ), m_filterChain( lst.begin(), lst.end() )
	{
	}

	inline MediaStreamSink::tCreateData::tCreateData( const GUID& cont_id, const smart_ptr<Codec>& pFIO, const tFrameFilterList& lst )
		: m_pContainer( 0 ), m_ContainerID( cont_id ), m_pCodec( pFIO ), m_Subtype( GUID_NULL ), m_filterChain( lst.begin(), lst.end() )
	{
	}

	inline MediaStreamSink::tCreateData::tCreateData( const GUID& cont_id, const GUID& subtype, const tFrameFilterList& lst )
		: m_pContainer( 0 ), m_ContainerID( cont_id ), m_pCodec( 0 ), m_Subtype( subtype ), m_filterChain( lst.begin(), lst.end() )
	{
	}

	inline MediaStreamSink::tCreateData& MediaStreamSink::tCreateData::operator=( const MediaStreamSink::tCreateData& op2 )
	{
		m_pContainer = op2.m_pContainer;
		m_ContainerID = op2.m_ContainerID;
		m_pCodec = op2.m_pCodec;
		m_Subtype = op2.m_Subtype;

		return *this;
	}

};

#endif // MEDIASTREAMSINK_H_INC_
