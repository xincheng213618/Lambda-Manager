
#ifndef _VIDEOFORMATDESC_H_
#define _VIDEOFORMATDESC_H_

#include "dstring.h"

#include "VideoFormatItem.h"

#include "int_interface_pre.h"
#include "smart_ptr.h"

namespace udshl
{
    class ISourceFilter;
    struct scanning_info;
}

namespace _DSHOWLIB_NAMESPACE
{
	class VideoFormatDesc
	{
        friend class udshl::ISourceFilter;
	public:
		UDSHL_EXP_API_ ~VideoFormatDesc();
	public:
		UDSHL_EXP_API_ VideoFormatItem	createVideoFormat( SIZE size ) const;
		UDSHL_EXP_API_ VideoFormatItem	createVideoFormat( int width, int height ) const;
	public:
		UDSHL_EXP_API_ GUID			getSubtype() const;
		UDSHL_EXP_API_ SIZE			getMinSize() const;
		UDSHL_EXP_API_ SIZE			getMaxSize() const;
		UDSHL_EXP_API_ SIZE			getStepSize() const;

		UDSHL_DEPRECATE_FUNCTION_T_( "VideoFormatDesc::getBinningFactorHorizontal() and VideoFormatDesc::getBinningFactorVertical() methods" )
		UDSHL_EXP_API_ int			getBinningFactor() const;

		// Internal use only
		UDSHL_EXP_API_ int			getBinningModeId() const;

		UDSHL_EXP_API_ int			getBinningFactorHorizontal() const;
		UDSHL_EXP_API_ int			getBinningFactorVertical() const;
		UDSHL_EXP_API_ int			getSkippingFactorHorizontal() const;
		UDSHL_EXP_API_ int			getSkippingFactorVertical() const;

		UDSHL_EXP_API_ bool			isROIFormat() const;

		UDSHL_EXP_API_ bool			isValidSize( const SIZE& sz ) const;

		/** get string representing this format desc
		 **/
		std::string		toString() const        { return wstoas( toString_() ); }
		std::wstring	toStringW() const       { return toString_(); }

		/** get string representing the color format of this format
		 * @return string representing the color format of this format
		 **/
		std::string		getColorformatString() const    { return wstoas( getColorformatString_() ); }
		std::wstring	getColorformatStringW() const   { return getColorformatString_(); }
	private:
		UDSHL_EXP_API_	dstringw		toString_() const;
		UDSHL_EXP_API_	dstringw		getColorformatString_() const;

		VideoFormatDesc( const VideoFormatDesc& op2 );
		VideoFormatDesc( const win32_utils::CVideoFormatDesc& desc, const udshl::scanning_info& smi, bool isROIFormat );

		smart_ptr<win32_utils::CVideoFormatDesc> m_pDesc;

		int		m_binningModeId;
		int		m_binningHorizontal;
		int		m_binningVertical;
		int		m_skippingHorizontal;
		int		m_skippingVertical;
		bool	m_isROIFormat;
		bool	m_dontAllowROI;
	};
}

#endif // _VIDEOFORMATDESC_H_
