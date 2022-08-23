// VideoFormatItem.h: interface for the VideoFormatItem class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_VIDEOFORMATITEM_H__AD23522D_3281_4115_8943_C22F95EE0957__INCLUDED_)
#define AFX_VIDEOFORMATITEM_H__AD23522D_3281_4115_8943_C22F95EE0957__INCLUDED_

#pragma once

#include <string>
#include "udshl_defs.h"

#include "int_interface_pre.h"
#include "dstring.h"
#include "FrameTypeInfo.h"

namespace udshl
{
    struct scanning_info;
}

namespace _DSHOWLIB_NAMESPACE
{
	class Grabber;
	class VideoFormatDesc;

	/** Represents a certain Video Format with its size and MEDIASUBTYPE/Colorformat.
	 * All members will deliver valid values only if isValid() returns true
	 **/
	class VideoFormatItem
	{
        friend Grabber;
		friend VideoFormatDesc;
        friend udshl::grabber_backend;
    public:
		/** constructs an empty VideoFormatItem
		 * the constructed item is invalid (see isValid())
		 * @see isValid()
		 **/
		UDSHL_EXP_API_ VideoFormatItem();
		UDSHL_EXP_API_ VideoFormatItem( const VideoFormatItem& op );
        UDSHL_EXP_API_ VideoFormatItem& operator=( const VideoFormatItem& op2 );
        UDSHL_EXP_API_ ~VideoFormatItem();

		/** test if instance is a valid format
		 * @return true if <code>this</code> is valid
		 **/
		UDSHL_EXP_API_ bool			isValid() const;

		/** get size of format
		 * @return the size of a frame with this format in a SIZE struct
		 **/
		UDSHL_EXP_API_ SIZE			getSize() const;

		/** get the bit count per pixel.
		 */
		UDSHL_EXP_API_ unsigned int	getBitsPerPixel() const;

		/** get color format
		 * @return the GUID of the color format of this format
		 **/
        UDSHL_DEPRECATE_FUNCTION_T_( "VideoFormatItem::getSubtype()" )
		UDSHL_EXP_API_ GUID			getColorformat() const;
		UDSHL_EXP_API_ GUID			getSubtype() const;

		/** get binning factor
		 *
		 **/
		UDSHL_DEPRECATE_FUNCTION_T_( "VideoFormatItem::getBinningFactorHorizontal() and VideoFormatItem::getBinningFactorVertical() methods" )
		UDSHL_EXP_API_ int			getBinningFactor() const;

		UDSHL_EXP_API_ int			getBinningFactorHorizontal() const;
		UDSHL_EXP_API_ int			getBinningFactorVertical() const;
		UDSHL_EXP_API_ int			getSkippingFactorHorizontal() const;
		UDSHL_EXP_API_ int			getSkippingFactorVertical() const;

		/**
		 * Internal use only
		 **/
		int							getBinningModeId() const { return m_binningModeId; }
	
		/** Creates a textual representation for this VideoFormatItem
		 * @return The textual representation.
		 */
		std::string		toString() const { return wstoas( toString_() ); }
		std::wstring	toStringW() const { return toString_(); }

		/** get string representing the dimensions of this format
		 * @return a string representing the size of a frame with this format
		 **/
		std::string		getSizeString() const { return getSizeString_(); }

		/** get string representing the color format of this format
		 * @return string representing the color format of this format
		 **/
		std::string		getColorformatString() const  { return wstoas( getColorformatString_() ); }
		std::wstring	getColorformatStringW() const { return getColorformatString_(); }


        UDSHL_EXP_API_
        FrameTypeInfo   getFrameType() const;

		UDSHL_EXP_API_ bool			operator<( const VideoFormatItem& op ) const;

		/** test if two formats are equal
		 * @param op format to compare to this
		 * @return true if this and op are equal, else false
		 **/
		UDSHL_EXP_API_ bool			operator==( const VideoFormatItem& op ) const;

		/** test if two formats are not equal
		 * @param op format to compare to this
		 * @return false if this and op are equal, else true
		 **/
        UDSHL_EXP_API_ bool         operator!=( const VideoFormatItem& op ) const;

		/** test if this is equal to the string passed in op
		 * @param op item to compare to this
		 * @return true if this and op are equal, else false
		 **/
        UDSHL_EXP_API_ bool         operator==( const dstringa& op ) const;
		UDSHL_EXP_API_ bool         operator==( const dstringw& op ) const;

		/** generates an invalid item
		 * @return an invalid item
		 * @see isValid()
		 **/
        UDSHL_DEPRECATE_FUNCTION_T_( "default constructor" )
		UDSHL_EXP_API_ static VideoFormatItem createInvalid();
	private:
		UDSHL_EXP_API_ dstringa		getSizeString_() const;
		UDSHL_EXP_API_ dstringw		toString_() const;
		UDSHL_EXP_API_ dstringw		getColorformatString_() const;

        win32_utils::CVideoFormat&          getVideoFormat_() { return *m_pInternalData; }
        win32_utils::CVideoFormat&          getVideoFormat_() const { return *m_pInternalData; }

		/** constructs a VideoFormatItem from a VideoFormat
		 * @param op2
		 **/
		VideoFormatItem( const win32_utils::CVideoFormat& op2, const udshl::scanning_info& smi );
		VideoFormatItem( const win32_utils::CVideoFormat& op2, int binId, int binH, int binV, int skipH, int skipV );

		win32_utils::CVideoFormat*	m_pInternalData;
		int							m_binningModeId;
		int							m_binningHorizontal;
		int							m_binningVertical;
		int							m_skippingHorizontal;
		int							m_skippingVertical;
		
		void			initVideoFormatStringMember();

		dstringa		m_VideoFormatString;		
	};

};

#endif // !defined(AFX_VIDEOFORMATITEM_H__AD23522D_3281_4115_8943_C22F95EE0957__INCLUDED_)
