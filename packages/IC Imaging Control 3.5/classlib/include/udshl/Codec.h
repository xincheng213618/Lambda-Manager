
#ifndef CODEC_H_INC_
#define CODEC_H_INC_

#pragma once

#include <string>
#include <vector>
#include "udshl_defs.h"

#include "smart_ptr.h"
#include "smart_com.h"

#include "dvector.h"
#include "dstring.h"

namespace codec_adapter
{
	class ICodecFilter;
}

namespace _DSHOWLIB_NAMESPACE
{
	class MediaStreamSink;
	class MediaStreamContainer;

	class Codec;

	typedef smart_ptr<Codec>		tCodecPtr;
	typedef std::vector<tCodecPtr>	tCodecList;
	typedef smart_ptr<tCodecList>	tCodecListPtr;

	/** Represents a Codec filter, which can be used in conjunction with the MediaStreamSink. */
	class Codec  
	{
		friend MediaStreamSink;
		friend MediaStreamContainer;
	public:
		/** Returns a tCodecListPtr containing the video compressors that were found on your system. 
		 */
		UDSHL_DEPRECATE_FUNCTION_T_( "getAvailableCodecList function" )
		static tCodecListPtr	getAvailableCodecs()
		{
			dvector<smart_ptr<Codec> > tmp = getAvailableCodecs_();
			if( tmp.empty() ) {
				return NULL;
            }
			return tCodecListPtr( new tCodecList( tmp.begin(), tmp.end() ) );
		}
        /** Returns a tCodecListPtr containing the video compressors that were found on your system. */
        static tCodecList	getAvailableCodecList()
        {
            dvector<smart_ptr<Codec> > tmp = getAvailableCodecs_();
            return tCodecList( tmp.begin(), tmp.end() );
        }

		UDSHL_EXP_API_ ~Codec();

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
		 *	if( pCodec->getInternalInterface( pItf ) == 0 )
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

		/** Returns the readable name of this Filter */
		std::string			getName()	const { return wstoas( toString_() ); }

		/** Creates a textual representation for this Codec
		 * @return The textual representation.
		 */
		std::string			toString() const    { return wstoas( toString_() ); }
		std::wstring		toStringW() const   { return toString_(); }

		/** test if two formats are equal
		 * @param op format to compare to this
		 * @return true if this and op are equal, else false
		 **/
		UDSHL_EXP_API_ bool			operator==( const Codec& op ) const;

		/** test if two formats are not equal
		 * @param op format to compare to this
		 * @return false if this and op are equal, else true
		 **/
        UDSHL_EXP_API_ bool         operator!=( const Codec& op ) const;

		/** test if this is equal to the string passed in op
		 * @param op item to compare to this
		 * @return true if this and op are equal, else false
		 **/
        UDSHL_EXP_API_ bool         operator==( const dstringa& op ) const;
		UDSHL_EXP_API_ bool         operator==( const dstringw& op ) const;

		/** returns true if this CODEC has an Dialog. */
		UDSHL_EXP_API_ bool			hasDialog() const;
		
		/** calls the Dialog and saves the Data retrieved after the operation in the local buffer.*/
		UDSHL_EXP_API_ bool			callDialog( HWND hParent = 0 );

		/** returns true if this is a Video for Windows CODEC */
		UDSHL_DEPRECATE_FUNCTION_
		UDSHL_EXP_API_ bool			isVfwCodec() const;

		/**	Returns if you can get/set the codec data.
		 * @return true/false
		 */
		UDSHL_EXP_API_ bool			hasSettings() const;

		/** Returns a string containing the settings of the codec. 
		 * The string may be empty, when no data can be saved/restored by the codec.
		 */
		std::string		getSettings() const         { return wstoas( getSettings_() ); }
		std::wstring	getSettingsW() const        { return getSettings_(); }

		/** This method is used to set previously retrieved codec data.
		 * @return true on success, false on failure
		 */
		UDSHL_EXP_API_ bool			setSettings( const dstringa& data );
		UDSHL_EXP_API_ bool			setSettings( const dstringw& data );
	private:
		UDSHL_EXP_API_
		static dvector<smart_ptr<Codec> >	getAvailableCodecs_();
		UDSHL_EXP_API_ dstringw			toString_() const;
		UDSHL_EXP_API_ dstringw			getSettings_() const;

		UDSHL_EXP_API_ HRESULT			getInternalInterface_( REFIID riid, void** ppv ) const;

		/// internal ctor
		Codec( const smart_com<icbase::IDShowFactoryObjectInfo>& op2 );
        Codec( const smart_com<codec_adapter::ICodecFilter>& op2 );

		/** returns the pointer to the current compressor filter, only needed in build filter graph in grabber.cpp */
        smart_com<codec_adapter::ICodecFilter>	getICodecFilter() const;

		smart_com<IUnknown>						get_codec_ref() const;

		bool									create_internal_filter() const;

		/// the user friendly readable name
		dstringw						m_ReadableName;

		/// holds the information to create a filter
		mutable smart_com<icbase::IDShowFactoryObjectInfo>	m_pFilterInfo;
		mutable smart_com<icbase::IDShowFilter>				m_pFilter;
		mutable smart_com<codec_adapter::ICodecFilter>		m_pCodecItf;
	};
}

#endif // CODEC_H_INC_
