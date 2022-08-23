
#ifndef FRAMEQUEUEBUFFER_H_INC_
#define FRAMEQUEUEBUFFER_H_INC_

#pragma once

#include <vector>

#include "FrameTypeInfo.h"
#include "Error.h"

namespace _DSHOWLIB_NAMESPACE
{
    /**
     * This is the interface class for IFrame derived actual frame buffers.
     * You can derive your own class from this, for a example see FrameQueueUserBuffer.
     */
    class FrameQueueBuffer : public IFrame
    {
    public:
        virtual ~FrameQueueBuffer() {}

        virtual void*       getUserPointer() const = 0;
    };

    typedef smart_ptr<FrameQueueBuffer>         tFrameQueueBufferPtr;
    typedef std::vector<tFrameQueueBufferPtr>   tFrameQueueBufferList;
    
    typedef dvector<tFrameQueueBufferPtr>       tFrameQueueBufferDVector;

    Error       createFrameQueueBuffer( tFrameQueueBufferPtr& rval, const FrameTypeInfo& type, void* userPtr = nullptr );
    Error       createFrameQueueBuffer( tFrameQueueBufferList& rval, const FrameTypeInfo& type, size_t count, void* userPtr = nullptr );
	UDSHL_EXP_API_ Error	createFrameQueueBuffer( tFrameQueueBufferPtr& rval, const FrameTypeInfo& type, BYTE* dataPointer, size_t dataSize, void* userPtr = nullptr );


    // internal functions
    UDSHL_EXP_API_ Error    createFrameQueueBuffer_( tFrameQueueBufferDVector& rval, const FrameTypeInfo& type, size_t count, void* userPtr, uint32_t flags = 0 );

    /**
     * This is a partial implementation of a FrameQueueBuffer.
     */
    class FrameQueueUserBuffer : public FrameQueueBuffer
    {
    private:
        smart_ptr<FrameMetaDataContainer>  secondary_data_;

        FrameTypeInfo       frame_type_;

        void*               user_ptr_;
        size_t              actual_data_size_;
    public:
        FrameQueueUserBuffer( const FrameTypeInfo& info, void* user_ptr = 0 )
            : frame_type_( info ), secondary_data_( createFrameMetaDataContainer() ), user_ptr_( user_ptr ), actual_data_size_( info.buffersize )
        {
        }

        virtual bool                        getMediaSampleInfo_( void* buffer, size_t buffer_len, size_t& data_available ) const
        {
            return secondary_data_->getMediaSampleInfo_( buffer, buffer_len, data_available );
        }
        virtual size_t                      getActualDataSize() const { return actual_data_size_; }
		virtual void						setActualDataSize( size_t newSize ) { actual_data_size_ = newSize; }

        virtual const FrameTypeInfo&	    getFrameType() const { return frame_type_; }
        virtual void*	                    getUserPointer() const { return user_ptr_; }

        virtual FrameMetaData         getFrameMetaData() const { return secondary_data_->getFrameMetaData(); }
    
        /* You have to implement this method in derived classes */
        virtual BYTE*                       getPtr() const = 0;
    public: // private functions, do not use!!
        virtual FrameMetaDataContainer*    getFrameMetadataContainer() { return &*secondary_data_; }
    };


    inline Error   createFrameQueueBuffer( tFrameQueueBufferList& rval, const FrameTypeInfo& type, size_t count, void* userPtr )
    {
        tFrameQueueBufferDVector buffers;
        Error err = createFrameQueueBuffer_( buffers, type, count, userPtr, 0 );
        if( err.isError() ) {
            return err;
        }
        rval = to_vector_move( buffers );
        return err;
    }
    inline Error   createFrameQueueBuffer( tFrameQueueBufferPtr& rval, const FrameTypeInfo& type, void* userPtr )
    {
        tFrameQueueBufferDVector buffers;
        Error err = createFrameQueueBuffer_( buffers, type, 1, userPtr, 0 );
        if( err.isError() ) {
            return err;
        }
        rval.swap( buffers.front() );
        return err;
    }
}

#endif // !FRAMEQUEUEBUFFER_H_INC_
