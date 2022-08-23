
#ifndef FRAMEQUEUESINK_H_INC_
#define FRAMEQUEUESINK_H_INC_

#pragma once

#include "GrabberSinkType.h"
#include "FrameQueueBuffer.h"

namespace udshl
{
    class frame_queue_sink_impl;
}

namespace _DSHOWLIB_NAMESPACE
{
    class FrameQueueSink;

    typedef smart_ptr<FrameQueueSink>           tFrameQueueSinkPtr;

    class FrameQueueSinkListener
    {
    public:
        virtual ~FrameQueueSinkListener() {}

        /**
         * Method gets called when the graph is connected and the resulting OutputFrameType is evaluated. You can (and should) queue buffers into the sink to get frames on time.
         * @param sink The actual sink where this listener is registered. Use this parameter to queue buffers, etc.
         * @param frameType the actual FrameTypeInfo of the buffers the sink expects/uses.
         */
        virtual void    sinkConnected( FrameQueueSink& sink, const FrameTypeInfo& frameType ) { UNREFERENCED_PARAMETER( &sink ); UNREFERENCED_PARAMETER( frameType ); }
        /**
         * Method gets called when the graph is about to disconnect.
         */
        virtual void    sinkDisconnected( FrameQueueSink& sink ) { UNREFERENCED_PARAMETER( &sink ); }
        virtual void    framesQueued( FrameQueueSink& sink ) = 0;
    };

    class FrameQueueSinkSimpleListenerBase : public FrameQueueSinkListener
    {
    public:
        explicit FrameQueueSinkSimpleListenerBase( int framesToAllocateOnConnect ) : framesToAllocateOnConnect_( framesToAllocateOnConnect )     {}

        enum tNotifyFrameResult
        {
            eREQUEUE,
            eSKIP_REQUEUE,
        };

        virtual void                notifySinkConnected( const FrameTypeInfo& frameType ) { UNREFERENCED_PARAMETER( frameType ); }
        virtual void                notifySinkDisconnected() {}
        virtual tNotifyFrameResult  notifyFrame( tFrameQueueBufferPtr buffer ) = 0;
    private:
        virtual void    sinkConnected( FrameQueueSink& sink, const FrameTypeInfo& frameType );
        virtual void    sinkDisconnected( FrameQueueSink& sink );
        virtual void    framesQueued( FrameQueueSink& sink );

        int             framesToAllocateOnConnect_;
    };

    Error   createFrameQueueBuffer( tFrameQueueBufferList& rval, const FrameQueueSink& sink, size_t count );
    Error   createFrameQueueBuffer( tFrameQueueBufferPtr& rval, const FrameQueueSink& type, BYTE* dataPointer, size_t dataSize, void* userPtr );
    Error   createFrameQueueBuffer( tFrameQueueBufferPtr& rval, const FrameQueueSink& sink );

    /**
     * FrameQueueSink can be used to get a sink with a frame queue where you can easily fetch 'copied' (output) frames and re-queue them when needed.
     * The sink state changes in the following way:
        1) attach sink to Grabber object

        2) Grabber.prepareLive/startLive is called
            -> Sink negotiates the 'right' output FrameTypeInfo and then connects inside the Graph
                -> Sink clears the 'output buffer queue' and the 'input buffer queue'
                    => sink.getInputQueueSize() == 0 && sink.getOutputQueueSize() == 0
                -> Sink calls user supplied FrameQueueSinkListener::sinkConnected
        3) The actual streaming begins
            -> Sink receives frame and getInputQueueSize() > 0
                Copy frame into input buffer and move input buffer into output queue
                Notify thread about new buffers in the copied queue
            ^-----
        4) Grabber.stopLive is called
            -> Sink stops accepting frames finishes copying
                => sink.isCancelRequested() == true
                    <=> waiting until frameQueued returns
            -> Sink calls FrameQueueSinkListener::sinkDisconnected
            -> Sink clears 'input buffer queue'
                => sink.getInputQueueSize() == 0
                => sink.getOutputQueueSize() can still be > 0, and this queue is not cleared until grabber.startLive is called
        5) goto 2)

        When the sink is connected a frame notify thread is running and waiting for frames to be copied.
        When the thread is notified it calls FrameQueueSinkListener::frameQueued
        When FrameQueueSinkListener::frameQueued returns the thread looks if new frames were copied and notifies FrameQueueSinkListener::frameQueued.

     * Default implementations:
        class UserFrameQueueSinkListener : public FrameQueueSinkListener
        {
        public:
            void    sinkConnected( FrameQueueSink& sink, const FrameTypeInfo& frameType ) override;
            void    sinkDisconnected( FrameQueueSink& sink ) override;
            void    framesQueued( FrameQueueSink& sink ) override;
        };

        void    UserFrameQueueSinkListener::sinkConnected( FrameQueueSink& sink, const FrameTypeInfo& frameType )
        {
            Error err = sink.allocAndQueueBuffers( 5 ); // default should be to allocate N buffers and queue them so that no frames are dropped when starting the graph
            if( err.isError() ) {
                // do something ...
            }
        }
        void    UserFrameQueueSinkListener::sinkDisconnected( FrameQueueSink& sink ) {
            // In most circumstances we don't need to do anything on disconnect. Note: You should not send messages here because this could trigger a deadlock

            // if we need the output buffers, we can grab them here, after this method returns the buffers are discarded internally
            // auto lst = sink.popAllQueuedBuffers();
        }

        // this is the most generic and easiest possible way to implement this:
        void    UserFrameQueueSinkListener::framesQueued( FrameQueueSink& sink )
        {
            do
            {
                tFrameQueueBufferPtr ptr = sink.popOutputBuffer();  // pop a single buffer from the 'copied buffer queue'
                if( ptr == NULL ) {                                 // if pop returns NULL no current buffers are available and we should again wait on new buffers by returning
                    return;
                }
                // do something with ptr

                sink.queueBuffer( ptr );                            // requeue the pop'ed buffer so that it can be again copied into
            }
            while( !sink.isCancelRequested() );                     // we check if we should stop processing buffers
        }
     */
    class FrameQueueSink : public GrabberSinkType
    {
    public:
        static tFrameQueueSinkPtr   create( FrameQueueSinkListener& listener )                                                  { return create( listener, FrameTypeInfoArray() ); }
        static tFrameQueueSinkPtr   create( FrameQueueSinkListener& listener, const FrameTypeInfo& type )                       { return create( listener, FrameTypeInfoArray( type ) ); }
        static tFrameQueueSinkPtr   create( FrameQueueSinkListener& listener, const FrameTypeInfoArray& acceptedFrameTypes )    { return create_( listener, acceptedFrameTypes.to_dvector() ); }

        static tFrameQueueSinkPtr   create( const smart_ptr<FrameQueueSinkListener>& listener )                                                 { return create( listener, FrameTypeInfoArray() ); }
        static tFrameQueueSinkPtr   create( const smart_ptr<FrameQueueSinkListener>& listener, const FrameTypeInfo& type )                      { return create( listener, FrameTypeInfoArray( type ) ); }
        static tFrameQueueSinkPtr   create( const smart_ptr<FrameQueueSinkListener>& listener, const FrameTypeInfoArray& acceptedFrameTypes )   { return create_( listener, acceptedFrameTypes.to_dvector() ); }
    private:
        UDSHL_EXP_API_ static tFrameQueueSinkPtr  create_( FrameQueueSinkListener& listener, const dvector<FrameTypeInfo>& acceptedFrameTypes );
        UDSHL_EXP_API_ static tFrameQueueSinkPtr  create_( const smart_ptr<FrameQueueSinkListener>& listener, const dvector<FrameTypeInfo>& acceptedFrameTypes );
    public:
        struct FrameCountInformation
        {
            uint64_t     framesCopied;
            uint64_t     framesDropped;
        };

        /* Allocates N buffers and queues them via queueBuffer.
         * This method fails when either the sink is not yet connected or no memory could be allocated.
         */
        Error                                       allocAndQueueBuffers( size_t count );

        /** Re enqueues the passed in buffer. The sink must be connected and the passed FrameQueueBuffer must have been allocated in this connection cycle with this sink.
         * @return Error
         */
        UDSHL_EXP_API_ Error                        queueBuffer( const tFrameQueueBufferPtr& buf );
        Error                                       queueBuffer( const tFrameQueueBufferList& lst );

        tFrameQueueBufferList                       popAllInputQueueBuffers();

        /** Returns either nullptr or the oldest copied buffer. You have to re-enqueue the buffer you got from this call so this sink does not run out of buffers to copy to.
         */
        UDSHL_EXP_API_ tFrameQueueBufferPtr         popOutputQueueBuffer();

        tFrameQueueBufferList                       popAllOutputQueueBuffers();

        /** Returns true when the backing thread has been requested to end. You should use this flag when doing long running work in a frameQueued listener function.
         */
        UDSHL_EXP_API_ bool                         isCancelRequested() const;

        /** Frame drop information for this sink. */
        UDSHL_EXP_API_ FrameCountInformation        getFrameCountInfo();

        /* Returns the count of queued free buffers to copy into. */
        UDSHL_EXP_API_ size_t                       getInputQueueSize();
        /* Returns the count of copied buffers queued in the output queue. */
        UDSHL_EXP_API_ size_t                       getOutputQueueSize();

        /** Returns the frame type of the IFrames in this sink
         *
         * @param info	When the information is available, then info is filled with the output frame type of the sink.
         * @return true when the information is available and info was filled with the according data, otherwise false.
         */
        UDSHL_EXP_API_ bool							getOutputFrameType( FrameTypeInfo& info ) const;
        UDSHL_EXP_API_ bool                         isConnected() const;

        UDSHL_EXP_API_ virtual tSinkType	        getSinkType() const;
    private:
        UDSHL_EXP_API_ Error                        queueBuffer( const tFrameQueueBufferDVector& vec );
        UDSHL_EXP_API_ void                         popAllInputQueueBuffers_( tFrameQueueBufferDVector& rval );
        UDSHL_EXP_API_ void                         popAllCopiedBuffers_( tFrameQueueBufferDVector& rval );
    private:
        FrameQueueSink( FrameQueueSinkListener& listener, const smart_ptr<FrameQueueSinkListener>& listener_tmp, const FrameTypeInfoArray& acceptedFrameTypes );

        // copying disabled:
        FrameQueueSink( const FrameQueueSink& );
        FrameQueueSink& operator=( const FrameQueueSink& );

        virtual bool	attach( GrabberPImpl* );
        virtual void	detach();

        virtual smart_com<icbase::IDShowFilter>	    getBaseSinkFilter() const;

        smart_ptr<udshl::frame_queue_sink_impl>     impl_;
    };

    inline Error                   FrameQueueSink::allocAndQueueBuffers( size_t count )
    {
        FrameTypeInfo tmpInfo;
        if( !getOutputFrameType( tmpInfo ) ) {
            return eSINK_NOT_CONNECTED;
        }
        tFrameQueueBufferDVector buffers;
        Error err = createFrameQueueBuffer_( buffers, tmpInfo, count, 0 );
        if( err.isError() ) {
            return err;
        }
        return queueBuffer( buffers );
    }
    inline Error            FrameQueueSink::queueBuffer( const tFrameQueueBufferList& lst )
    {
        return queueBuffer( tFrameQueueBufferDVector( lst.begin(), lst.end() ) );
    }
    inline tFrameQueueBufferList   FrameQueueSink::popAllOutputQueueBuffers()
    {
        tFrameQueueBufferDVector vec;
        popAllCopiedBuffers_( vec );
        return to_vector_move( vec );
    }
    inline tFrameQueueBufferList   FrameQueueSink::popAllInputQueueBuffers()
    {
        tFrameQueueBufferDVector vec;
        popAllInputQueueBuffers_( vec );
        return to_vector_move( vec );
    }

    inline Error   createFrameQueueBuffer( tFrameQueueBufferList& rval, const FrameQueueSink& sink, size_t count )
    {
        FrameTypeInfo tmpInfo;
        if( !sink.getOutputFrameType( tmpInfo ) ) {
            return eSINK_NOT_CONNECTED;
        }
        return createFrameQueueBuffer( rval, tmpInfo, count );
    }
    inline Error   createFrameQueueBuffer( tFrameQueueBufferPtr& rval, const FrameQueueSink& sink )
    {
        FrameTypeInfo tmpInfo;
        if( !sink.getOutputFrameType( tmpInfo ) ) {
            return eSINK_NOT_CONNECTED;
        }
        return createFrameQueueBuffer( rval, tmpInfo );
    }

    inline Error   createFrameQueueBuffer( tFrameQueueBufferPtr& rval, const FrameQueueSink& sink, BYTE* dataPointer, size_t dataSize, void* userPtr )
    {
        FrameTypeInfo tmpInfo;
        if( !sink.getOutputFrameType( tmpInfo ) ) {
            return eSINK_NOT_CONNECTED;
        }
        return createFrameQueueBuffer( rval, tmpInfo, dataPointer, dataSize, userPtr );
    }

    inline void    FrameQueueSinkSimpleListenerBase::sinkConnected( FrameQueueSink& sink, const FrameTypeInfo& frameType )
    {
        sink.allocAndQueueBuffers( framesToAllocateOnConnect_ );
        notifySinkConnected( frameType );
    }
    inline void    FrameQueueSinkSimpleListenerBase::sinkDisconnected( FrameQueueSink& /*sink*/ ) { notifySinkDisconnected(); }
    inline void    FrameQueueSinkSimpleListenerBase::framesQueued( FrameQueueSink& sink )
    {
        while( !sink.isCancelRequested() )
        {
            tFrameQueueBufferPtr buf = sink.popOutputQueueBuffer();
            if( buf == NULL )
            {
                return;
            }
            tNotifyFrameResult res = notifyFrame( buf );
            if( res == eREQUEUE )
            {
                sink.queueBuffer( buf );
            }
        }
    }

}

#endif