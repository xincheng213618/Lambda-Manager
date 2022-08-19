
#ifndef FRAMESNAPSINK_H_INC_
#define FRAMESNAPSINK_H_INC_

#pragma once

#include "GrabberSinkType.h"
#include "FrameQueueBuffer.h"

namespace udshl
{
    class frame_snap_sink_impl;
}

namespace _DSHOWLIB_NAMESPACE
{
    class FrameSnapSink;

    typedef smart_ptr<FrameSnapSink>           tFrameSnapSinkPtr;

    Error   createFrameQueueBuffer( tFrameQueueBufferPtr& rval, const FrameSnapSink& sink );
    Error   createFrameQueueBuffer( tFrameQueueBufferPtr& rval, const FrameSnapSink& type, BYTE* dataPointer, size_t dataSize, void* userPtr );
    Error   createFrameQueueBuffer( tFrameQueueBufferList& rval, const FrameSnapSink& sink, size_t count );

    class FrameSnapSink : public GrabberSinkType
    {
    public:
        static tFrameSnapSinkPtr   create( size_t bufferCountToAllocateAfterConnect = 0 )                                                  { return create( FrameTypeInfoArray(), bufferCountToAllocateAfterConnect ); }
        static tFrameSnapSinkPtr   create( const FrameTypeInfo& type, size_t bufferCountToAllocateAfterConnect = 0 )                       { return create( FrameTypeInfoArray( type ), bufferCountToAllocateAfterConnect ); }
        static tFrameSnapSinkPtr   create( const FrameTypeInfoArray& acceptedFrameTypes, size_t bufferCountToAllocateAfterConnect = 0 )    { return create( acceptedFrameTypes.to_dvector(), bufferCountToAllocateAfterConnect ); }

        UDSHL_EXP_API_ static tFrameSnapSinkPtr  create( const dvector<FrameTypeInfo>& acceptedFrameTypes, size_t bufferCountToAllocateAfterConnect );
    public:
        UDSHL_EXP_API_ Error        allocAndQueueBufferCache( size_t count );

        tFrameQueueBufferPtr        snapSingle( int64_t timeout_in_ms = -1 );
        Error                       snapSingle( tFrameQueueBufferPtr& rval, int64_t timeout_in_ms = -1 );

        tFrameQueueBufferList       snapSequence( size_t count, int64_t timeout_in_ms = -1 );
        Error                       snapSequence( tFrameQueueBufferList& rval, size_t count, int64_t timeout_in_ms = -1 );

        /** Returns the frame type of the IFrames in this sink
         *
         * @param info	When the information is available, then info is filled with the output frame type of the sink.
         * @return true when the information is available and info was filled with the according data, otherwise false.
         */
        UDSHL_EXP_API_ bool							getOutputFrameType( FrameTypeInfo& info ) const;

        UDSHL_EXP_API_ virtual tSinkType	        getSinkType() const;
    public:
        UDSHL_EXP_API_ Error    snapSequence_( tFrameQueueBufferDVector& rval, size_t count, int64_t timeout_in_ms, uint32_t flags );
    private:
        FrameSnapSink( const FrameTypeInfoArray& acceptedFrameTypes, size_t bufferCountToAllocateAfterConnect );

        // copying disabled:
        FrameSnapSink( const FrameSnapSink& );
        FrameSnapSink& operator=( const FrameSnapSink& );

        virtual bool	attach( GrabberPImpl* );
        virtual void	detach();

        virtual smart_com<icbase::IDShowFilter>	    getBaseSinkFilter() const;

        smart_ptr<udshl::frame_snap_sink_impl>      impl_;
    };

    inline tFrameQueueBufferPtr    FrameSnapSink::snapSingle( int64_t timeout_in_ms )
    {
        tFrameQueueBufferDVector lst;
        Error err = snapSequence_( lst, 1, timeout_in_ms, 0 );
        if( err.isError() || lst.empty() ) {
            return tFrameQueueBufferPtr();
        }
        return lst.front();
    }
    inline Error           FrameSnapSink::snapSingle( tFrameQueueBufferPtr& rval, int64_t timeout_in_ms )
    {
        tFrameQueueBufferDVector tmp;
        if( rval != NULL ) {
            tmp.push_back( rval );
        }
        Error err = snapSequence_( tmp, 1, timeout_in_ms, 0 );
        if( !tmp.empty() ) {
            rval.swap( tmp.front() );
        }
        return err;
    }

    inline tFrameQueueBufferList   FrameSnapSink::snapSequence( size_t count, int64_t timeout_in_ms )
    {
        tFrameQueueBufferDVector lst;
        Error err = snapSequence_( lst, count, timeout_in_ms, 0 );
        if( err.isError() || lst.empty() ) {
            return tFrameQueueBufferList();
        }
        return to_vector_move( lst );
    }
    inline Error           FrameSnapSink::snapSequence( tFrameQueueBufferList& rval, size_t count, int64_t timeout_in_ms )
    {
        tFrameQueueBufferDVector tmp = to_dvector( rval );
        Error err = snapSequence_( tmp, count, timeout_in_ms, 0 );
        rval = to_vector_move( tmp );
        return err;
    }

    inline Error   createFrameQueueBuffer( tFrameQueueBufferList& rval, const FrameSnapSink& sink, size_t count )
    {
        FrameTypeInfo tmpInfo;
        if( !sink.getOutputFrameType( tmpInfo ) ) {
            return eSINK_NOT_CONNECTED;
        }
        return createFrameQueueBuffer( rval, tmpInfo, count );
    }
    inline Error   createFrameQueueBuffer( tFrameQueueBufferPtr& rval, const FrameSnapSink& sink )
    {
        FrameTypeInfo tmpInfo;
        if( !sink.getOutputFrameType( tmpInfo ) ) {
            return eSINK_NOT_CONNECTED;
        }
        return createFrameQueueBuffer( rval, tmpInfo );
    }
    inline Error   createFrameQueueBuffer( tFrameQueueBufferPtr& rval, const FrameSnapSink& sink, BYTE* dataPointer, size_t dataSize, void* userPtr )
    {
        FrameTypeInfo tmpInfo;
        if( !sink.getOutputFrameType( tmpInfo ) ) {
            return eSINK_NOT_CONNECTED;
        }
        return createFrameQueueBuffer( rval, tmpInfo, dataPointer, dataSize, userPtr );
    }
}

#endif