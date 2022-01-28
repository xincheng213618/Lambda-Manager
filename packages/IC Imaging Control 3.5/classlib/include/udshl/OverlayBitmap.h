// OverlayBitmap.h: interface for the OverlayBitmap class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_OVERLAYBITMAP_H__54CAEF21_A1DC_4441_9C7B_76B953EC4D1C__INCLUDED_)
#define AFX_OVERLAYBITMAP_H__54CAEF21_A1DC_4441_9C7B_76B953EC4D1C__INCLUDED_

#pragma once

#include <string>

#include "udshl_defs.h"
#include "smart_com.h"
#include "simplectypes.h"

#include "dstring.h"
#include "FrameTypeInfo.h"

#include "int_interface_pre.h"

namespace udshl
{
    class COverlayBitmapContainer;
}

namespace _DSHOWLIB_NAMESPACE
{
	/** With this class you can create and control an overlay drawn onto the frames as they
	 * are transformed by the system.
	 * You can get a reference to this class by calling Grabber::getOverlay() or when you get called by
	 * the GrabberLister::overlayBitmap event.
	 */
	class OverlayBitmap
	{
        friend udshl::grabber_backend;
	public:
		/** dtor */
        UDSHL_EXP_API_ ~OverlayBitmap();

		/** returns an HDC in which the bitmap for the overlay is selected.
		 * The DC is only valid when beginPaint() was called.
		 * @return HDC on success otherwise 0
		 */
        UDSHL_EXP_API_ HDC			getDC() const;

		/** sets the current drop out color, which is not drawn into the stream. */
        UDSHL_EXP_API_ bool		setDropOutColor( COLORREF clr );
		/** gets the current drop out color. */
        UDSHL_EXP_API_ COLORREF	getDropOutColor() const;

		/** sets if the overlay is drawn vertically flipped into the frame. */
        UDSHL_EXP_API_ bool		setFlipVertical( bool bFlip );
		/** returns if the overlay is flipped vertically. */
        UDSHL_EXP_API_ bool		getFlipVertical() const;

		/** enables/disables the overlay. */
        UDSHL_EXP_API_ bool		setEnable( bool bOnOff );
		/** returns if the overlay is enabled. */
        UDSHL_EXP_API_ bool		getEnable() const;

		/** returns the width of the overlay. */
        UDSHL_EXP_API_ long		getWidth() const;
		/** returns the height of the overlay. */
        UDSHL_EXP_API_ long		getHeight() const;

		/** begin paint selects the bitmap into the DC and increases the begin paint count.
		 * You have to call this method before you do any operation on the DC.
		 * Internally the draw* methods call beginPaint, but it is better that you call beginPaint before you do
		 * any drawing onto the bitmap.
		 * When you are done with your drawing tasks, call endPaint.
		 * Your calls to beginPaint must match those to endPaint to prevent resource leaks.
		 */
        UDSHL_EXP_API_ bool		beginPaint();
		/** for each beginPaint you call, there must be corresponding endPaint in your code when you are
		 * done drawing to the DC.
		 */
        UDSHL_EXP_API_ bool		endPaint();

		/** Sets a new font object by its name. */
		UDSHL_EXP_API_ bool		setFont( const char* szFaceName, int iSize = 10 );
		UDSHL_EXP_API_ bool		setFont( const dstringa& szFaceName, int iSize = 10 );
		UDSHL_EXP_API_ bool		setFont( const dstringw& szFaceName, int iSize = 10 );

		/** Sets the current font for the next calls to drawText.
		 * adds a reference count to pFont, which is internally released when the font is not used
		 * anymore.
		 * @param pFont IFont derived object. (e.g. created by OleCreateFontIndirect(...) )
		 */
        UDSHL_EXP_API_ bool		setFont( IFont* pFont );
		/** Returns a reference to the currently set font object.
		 * You have to release the outstanding reference count of the returned pointer by calling "Release()"
		 * on the object.
		 * @return The current IFont object used internally by drawText().
		 */
        UDSHL_EXP_API_ IFont*		getFont() const;

		/** sets the background mode for drawText. */
        UDSHL_EXP_API_ void		setFontTransparent( bool val );
		/** returns the background mode for drawText. */
        UDSHL_EXP_API_ bool		getFontTransparent() const;

		/** sets the background color for drawText, which is used when getFontTransparent() == false. */
        UDSHL_EXP_API_ void		setFontBKColor( COLORREF background );
		/** return the background color which is used in drawText. */
        UDSHL_EXP_API_ COLORREF	getFontBKColor() const;

		/** draws a text at the specified position onto the overlay.
		 * The text is drawn in the color supplied. If getFontTransparent() == false then the text background
		 * is drawn in the color specified in setFontBKColor().
		 * @param color the foreground color in which the text is drawn.
		 * @param iX the start x position at which the text is drawn.
		 * @param iY the start y position at which the text is drawn.
		 * @param szText the text which is drawn onto the overlay.
		 */
		UDSHL_EXP_API_ bool		drawText( COLORREF color, int iX, int iY, const char* text );
		UDSHL_EXP_API_ bool		drawText( COLORREF color, int iX, int iY, const dstringa& text );
		UDSHL_EXP_API_ bool		drawText( COLORREF color, int iX, int iY, const dstringw& text );

		/** draws a line a specified onto the surface. */
        UDSHL_EXP_API_ bool		drawLine(COLORREF color, int iXStart, int iYStart, int iXEnd, int iYEnd);
		/** draws a rectangle onto the overlay, which is completely filled with the color specified. */
        UDSHL_EXP_API_ bool		drawSolidRect( COLORREF clr, const RECT& rect );

		UDSHL_EXP_API_ bool		drawFrameRect( COLORREF clr, const RECT& rect );
		UDSHL_EXP_API_ bool		drawSolidEllipse( COLORREF color, const RECT& rect );
		UDSHL_EXP_API_ bool		drawFrameEllipse( COLORREF color, const RECT& rect );
		/** fills the entire overlay with the color specified. */
        UDSHL_EXP_API_ bool		fill(COLORREF Color);

		/** returns if you can render bitmaps onto the overlay.
		 * This is not possible when you specify a FrameGrabberSink with UYVY as target.
		 *
		 * deprecated, always returns true
		 */
        UDSHL_DEPRECATE_FUNCTION_
        UDSHL_EXP_API_ bool				canRender() const;

		/** Returns the colorformat currently used by the overlay.
		 * @return Either the according colorformat or eInvalidColorformat when the overlay is currently not used.
		 */
        UDSHL_EXP_API_ tColorformatEnum	getColorformat() const;

		// since 3.0
		enum tOVBColorMode
		{
			eBESTFIT = 0,		//< let the OVB decide
			eGRAYSCALE,			//< force the OVB to grayscale
			eCOLOR,				//< force the OVB to color
		};

		/** You can set the color mode of the OverlayBitmap by specifying one of the
		 * tOVBColorMode members.
		 * @param newMode	The mode to set. This mode will only be accepted when the Grabber
		 *						which owns this OverlayBitmap is not in live mode.
		 * @return	true on success, false otherwise
		 */
		UDSHL_EXP_API_ bool				    setColorMode( tOVBColorMode newMode );
		UDSHL_EXP_API_ tOVBColorMode		getColorMode() const;

		/** Returns the position of the OverlayBitmap in the render path. This is helpful if you use
		 * more than one overlay in your setup.
		 */
        UDSHL_EXP_API_ tPathPosition		getPathPosition() const;

		/** Returns the currently used frame type.
		 * This function is available even outside of live mode, but the returned frame type may not
		 * correspond to the frame type after the next startLive call.
		 * @return	Frame type of the OverlayBitmap.
		 */
        UDSHL_EXP_API_ FrameTypeInfo		getFrameType() const;
	protected:
		/** internal ctor, do not use. */
		explicit OverlayBitmap( udshl::COverlayBitmapContainer* pData );
		mutable udshl::COverlayBitmapContainer*	m_pData;
	};
}

#endif // !defined(AFX_OVERLAYBITMAP_H__54CAEF21_A1DC_4441_9C7B_76B953EC4D1C__INCLUDED_)
