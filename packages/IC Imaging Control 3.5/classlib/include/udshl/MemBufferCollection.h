// MemBufferCollection.h: interface for the MemBuffer class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_MEMBUFFERCOLLECTION_H__9DAE8989_42EC_4A63_8328_AD5829AD2D11__INCLUDED_)
#define AFX_MEMBUFFERCOLLECTION_H__9DAE8989_42EC_4A63_8328_AD5829AD2D11__INCLUDED_

#pragma once

#include <string>

#include "udshl_defs.h"
#include "simplectypes.h"
#include "smart_ptr.h"

#include "Error.h"
#include "FrameTypeInfo.h"

namespace udshl
{
    struct MemBufferCollectionPImpl;
}

namespace _DSHOWLIB_NAMESPACE
{
	class MemBuffer;
	class MemBufferCollection;

	typedef smart_ptr<MemBufferCollection> tMemBufferCollectionPtr;


    /// Pattern to user for a buffer fill (to use when debugging)
    enum tPatternEnum
    {
        eTERMINATION,			///< fills with 0 and all bits set for all values of the last pixel
        eBWH,					///< fills with horizontal lines, black/white
        eBWV,					///< fills with vertical lines, black/white
        eBWQ,					///< fills with alternate pixels (mini quads) black/white
    };

	/** this class implements a memory buffer handling for image buffers.
	 * it can collect multiple buffers of the same type, i. e. with the same size and colorformat.
	 * The class provides an init() method to initialize the internal buffers. Any Errors can be
	 * queried by getLastError(). MemBufferCollection can handle user allocated buffers or allocates
	 * memory for you.
	 **/
	UDSHL_DEPRECATE_FUNCTION_T_( "use FrameQueueBuffer with FrameQueueSink, FrameSnapSink or FrameNotificationSink" )
	class MemBufferCollection
	{
	public:
		UDSHL_EXP_API_ ~MemBufferCollection();

		typedef smart_ptr<MemBuffer> tMemBufferPtr;
		typedef smart_ptr<BITMAPINFOHEADER> tBmInfHPtr;

		/** get frame Size
		 * @return size of each Frame in the buffer
		 **/
        UDSHL_DEPRECATE_FUNCTION_T_( "MemBuffer::getFrameType().dim" )
        UDSHL_EXP_API_ const SIZE&					getFrameSize() const;

		/** get colorformat
		 * @return colorformat for that the buffer was initialized.
		 * If the buffer is uninitialized, the return value is undefined.
		 **/
        UDSHL_DEPRECATE_FUNCTION_T_( "MemBuffer::getFrameType().getColorformat()" )
        UDSHL_EXP_API_ tColorformatEnum			    getColorformat() const;

		/** get bit per pixel
		 * @return number of bits per pixel for the current colorformat
		 **/
        UDSHL_DEPRECATE_FUNCTION_T_( "MemBuffer::getFrameType().getBitsPerPixel()" )
        UDSHL_EXP_API_ int						    getBitsPerPixel() const;

		/** get buffer length
		 * @return count of buffers in the collections
		 **/
		UDSHL_EXP_API_ unsigned int					    getBufferCount() const;

		/** get a MemBuffer with a certain index
		 * @param pos frame number (starting from 0)
		 * @return the queried MemBuffer
		 **/
		UDSHL_EXP_API_ tMemBufferPtr				operator[]( unsigned int pos ) const;

		/** get a MemBuffer with a certain index
		 * @param pos frame number (starting from 0)
		 * @return the queried MemBuffer
		 **/
		UDSHL_EXP_API_ tMemBufferPtr				getBuffer( unsigned int pos ) const;

		/** get the size of one frame buffer
		 * @return the size of one frame buffer in bytes
		 **/
        UDSHL_DEPRECATE_FUNCTION_T_( "MemBuffer::getFrameType().buffersize" )
        UDSHL_EXP_API_ size_t				        getBufferSize() const; // in bytes

		/// @return the last occurred error
        UDSHL_DEPRECATE_FUNCTION_TEXT_( "This error value is only used in the deprecated save methods." )
		UDSHL_EXP_API_ Error						getLastError() const;


		/** fills given buffer with a certain pattern.
		 * @param buffno number of buffer to fill with pattern
		 * @return true on success
		 **/
        UDSHL_DEPRECATE_FUNCTION_
        UDSHL_EXP_API_ bool						fillWithPattern( unsigned int buffno, tPatternEnum pattern );

		/** fills every buffer with a certain pattern.
		 * @return true on success
		 **/
        UDSHL_DEPRECATE_FUNCTION_
		UDSHL_EXP_API_ bool						fillWithPattern( tPatternEnum pattern );

		/** writes buffers to disk in a bmp-file for each buffer.
		 * <bold>Attention:</bold> existing file are overwritten.
		 * @param filename is a path and filename relative to the current directory. The name must
		 * contain one '*' character which will be replaced by the collection number of the
		 * buffers.
		 * @return true on success, else false
		 **/
		UDSHL_DEPRECATE_FUNCTION_T_( "saveToFileBMP functions in a loop" )
		UDSHL_EXP_API_ bool						save( const dstringa& filename ) const;
        UDSHL_DEPRECATE_FUNCTION_T_( "saveToFileBMP functions in a loop" )
		UDSHL_EXP_API_ bool						save( const dstringw& filename ) const;

		/** return pointer to BitmapInfoHeader struct according to the buffers. 
		 * The size of the returned buffer is sizeof( BITMAPINFOHEADER ) + sizeof( RGBQUAD ) * tBmInfHPtr->biClrUsed
		 * @return smart_ptr< BITMAPINFOHEADER > with BitmapInfoHeader to this collection
		 **/
        UDSHL_DEPRECATE_FUNCTION_T_( "createBitmapInfoHeader( IFrame& ) free function on a MemBuffer/IFrame" )
        UDSHL_EXP_API_ tBmInfHPtr					getBitmapInfoHeader() const;


		// since 2.0
		/** get the size of the valid data in the buffer itself.
		 * User allocated buffer may be larger than the actual data which is defined through
		 * (getFrameSize().cx * getFrameSize().cy * getBitsPerPixel()) / 8.
		 */
        UDSHL_DEPRECATE_FUNCTION_T_( "MemBuffer::getFrameType().buffersize" )
        UDSHL_EXP_API_ size_t					getBufferDataSize() const; // in bytes

		/** internal method, do not use.
		 */
        UDSHL_DEPRECATE_FUNCTION_T_( "MemBuffer::getFrameType().subtype" )
		UDSHL_EXP_API_ GUID						getMediaSubtype() const;

		// since 3.0
		/* Returns the frame type of the collection. */
        UDSHL_DEPRECATE_FUNCTION_T_( "MemBuffer::getFrameType()" )
        UDSHL_EXP_API_ const FrameTypeInfo&		getFrameType() const;

		/** Creates a MemBufferCollection for use with the FrameHandlerSink or the Grabber.
		 * @param frame_type	Must contain a fully specified frame type (no partial frame type allowed).
		 * @param count			The number of buffers the collection should contain. Must be > 0.
		 * @return 0 when one of the parameters is not valid, otherwise a MemBufferCollection instance.
		 */
		UDSHL_EXP_API_ static tMemBufferCollectionPtr		create( const FrameTypeInfo& frame_type, size_t count );

		/** Creates a MemBufferCollection for use with the FrameHandlerSink or the Grabber.
		 * @param frame_type	Must contain a fully specified frame type (no partial frame type allowed).
		 * @param count			The number of buffers the collection should contain. Must be > 0.
		 * @param buffers		The user specified image data pointers. These will be used by the MemBuffers for the
		 *							image data. The array must contain <count> pointers, which must not be 0.
		 * @return 0 when one of the parameters is not valid, otherwise a MemBufferCollection instance.
		 */
		UDSHL_EXP_API_ static tMemBufferCollectionPtr		create( const FrameTypeInfo& frame_type, size_t count, BYTE* buffers[] );

		/** Creates a new MemBufferCollection from  a colorformat and image dimensions.
		 * @param colorformat	The colorformat of the MemBuffers. Must be a valid colorformat.
		 * @param dim			The dimensions of the MemBuffers created. Must be > 0
		 * @param count			The number of buffers the collection should contain. Must be > 0.
		 * @return 0 when one of the parameters is not valid, otherwise a MemBufferCollection instance.
		 **/
		UDSHL_EXP_API_ static tMemBufferCollectionPtr		create( tColorformatEnum colorformat, SIZE dim, size_t count );

		/** Creates a new MemBufferCollection from a colorformat and image dimensions.
		 * The MemBuffers in the collection get the pointers you specified as image data pointers.
		 * @param colorformat	The colorformat of the MemBuffers. Must be a valid colorformat.
		 * @param dim			The dimensions of the MemBuffers created. Must be > 0
		 * @param count			The number of buffers the collection should contain. Must be > 0.
		 * @param buffers		The user specified image data pointers. These will be used by the MemBuffers for the
		 *							image data. The array must contain <count> pointers, which must not be 0.
		 * @return 0 when one of the parameters is not valid, otherwise a MemBufferCollection instance.
		 **/
		UDSHL_EXP_API_ static tMemBufferCollectionPtr		create( tColorformatEnum colorformat, SIZE dim, size_t count, BYTE* buffers[] );
	protected:
		MemBufferCollection( const FrameTypeInfo& type, size_t buffercount, BYTE* buffers[] );
	private:
		/** Copying of MemBufferCollection objects is prohibited. */
		MemBufferCollection( const MemBufferCollection& op );
		void	operator=( const MemBufferCollection& op2 );

		udshl::MemBufferCollectionPImpl*	m_pP;
	};
}

#endif // !defined(AFX_MEMBUFFERCOLLECTION_H__9DAE8989_42EC_4A63_8328_AD5829AD2D11__INCLUDED_)
