
#pragma once

#include <vector>

#include "udshl_defs.h"
#include "smart_ptr.h"

#include "MediaSampleInfo.h"
#include "simplectypes.h"

namespace _DSHOWLIB_NAMESPACE
{
    struct FrameTypeInfo;
    class FrameMetaDataContainer;

    struct FrameMetaData
    {
        tsMediaSampleDesc   mediaSampleDesc;
        MediaSampleInfo     mediaSampleInfo;
    };

	/** An object implementing the IFrame interface permits access to its image data and the
	 * frame type of the image.
	 *
	 * The pointer returned from getPtr may only be valid in the scope of the function in which get a reference
	 * to the IFrame passed in.
     *
     * DO NOT INHERIT from this class. If you need to, inherit from FrameQueueUserBuffer
	 */
	class IFrame
	{
    public:
        virtual ~IFrame() {};

	public:
		/** Returns the frame type of this frame. */
		virtual const FrameTypeInfo&	getFrameType() const = 0;

		/** Get pointer to the frame data.
		 * @return pointer to the frame buffer. This may be 0.
		 **/
		virtual BYTE*					getPtr() const = 0;

        /** Returns the actual data size.
         * In most cases this is == getFrameType().buffersize.
         * For MJPEG and comparable formats, this size indicates the real size of the data in this frame.
         */
        virtual size_t                  getActualDataSize() const = 0;
		virtual void				    setActualDataSize( size_t newSize ) = 0;

        /** Returns FrameMetaData attached to this frame.
         */
        virtual FrameMetaData           getFrameMetaData() const = 0;

        /* Retrieves the extended sample info
         * You have to supply a copy target. When the buffer is too small, no data is copied.
         *
         * Internal function, use media_sample_info::update to fill the according structure and then perform the necessary operations on that.
         *
         * @param data_available    contains the count of bytes that are available.
         * @return Returns false when no data is available or the buffer passed in is too small,
         *          true otherwise.
         */
        virtual bool                    getMediaSampleInfo_( void* buffer, size_t buffer_len, size_t& data_available ) const = 0;
	public: // private functions, do not use!!
        virtual FrameMetaDataContainer* getFrameMetadataContainer() = 0;
	public: // helper methods
        /** Returns the sample description. */
        UDSHL_DEPRECATE_FUNCTION_T_( "IFrame::getFrameMetaData()" )
        tsMediaSampleDesc	            getSampleDesc() const { return getFrameMetaData().mediaSampleDesc; }

        void                            getMediaSampleInfoBlob( std::vector<uint8_t>& data ) const;
        std::vector<uint8_t>            getMediaSampleInfoBlob() const { std::vector<uint8_t> tmp; getMediaSampleInfoBlob( tmp ); return tmp; }
    };

    class FrameMetaDataContainer
    {
    public:
        virtual ~FrameMetaDataContainer() {}
        virtual bool            getMediaSampleInfo_( void* buffer, size_t buffer_len, size_t& data_available ) const = 0;
        virtual FrameMetaData   getFrameMetaData() const = 0;
    };

    /**
     *	This creates a helper to implement a IFrame derived frame buffer object.
        All IFrame methods (outside getPtr()) are implemented and a frame buffer object can forward the IFrame requests to this.
     */
    UDSHL_EXP_API_    smart_ptr<FrameMetaDataContainer>   createFrameMetaDataContainer();

    /**
     * Copies the contents from src into dst irrespective of FrameType.
     * This method fails to copy anything if the dst frame is too small for the actual data contained in the source frame.
     * This copies the Metadata of the source frame and the memory pointer to by src.GetPtr
     */
    UDSHL_EXP_API_  bool    copyIFrame( IFrame& dst, const IFrame& src );
    /**
     * Copies only the metadata of the source frame.
     */
    UDSHL_EXP_API_  void    copyIFrameMetadata( IFrame& dst, const IFrame& src );


    inline void    IFrame::getMediaSampleInfoBlob( std::vector<uint8_t>& data ) const
    {
        if( data.size() < 1024 )      // optimization, don't shrink size if enough space would be available
        {
            data.clear();             // clear so that the resize does not need to copy
            data.resize( 1024 );      // allocate 1024 for the first try
        }

        size_t data_available = 0;
        bool rval = getMediaSampleInfo_( &data[0], data.size(), data_available );
        if( data_available == 0 )   // there is no data available
        {
            data.clear();
            return;
        }
        if( !rval )
        {
            data.resize( data_available );        // resize to accommodate more data

            data_available = 0;
            rval = getMediaSampleInfo_( &data[0], data.size(), data_available );
            if( !rval )     // some other error
            {
                data_available = 0;
            }
        }
        data.resize( data_available );
    }

    namespace detail
    {
        UDSHL_EXP_API_  void    copyMetaData( FrameMetaDataContainer* dst, const FrameMetaDataContainer* src );
    }
}