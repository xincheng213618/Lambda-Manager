
#ifndef FRAMENOTIFICATIONSINK_H_INC_
#define FRAMENOTIFICATIONSINK_H_INC_

#pragma once

#include "GrabberSinkType.h"
#include "FrameTypeInfo.h"

namespace udshl
{
    class notification_sink_impl_handle;
}

namespace _DSHOWLIB_NAMESPACE
{
    class FrameNotificationSink;

    typedef smart_ptr<FrameNotificationSink> tFrameNotificationSinkPtr;

    class FrameNotificationSinkListener
    {
    public:
        virtual ~FrameNotificationSinkListener() {}

        virtual void    sinkConnected( const FrameTypeInfo& frameType ) { UNREFERENCED_PARAMETER( frameType ); }
        virtual void    sinkDisconnected() {}

        virtual void    frameReceived( IFrame& frame ) = 0;
    };

    class FrameNotificationSink : public GrabberSinkType
    {
    public:
        /** Creates a sink with the associated listener.
         * @param cb    Listener to be called when a frame is received.
         * @return	!= 0 when this chain could be created.
         *			== 0 when the chain could not be setup because one input/output frame type combination was invalid.
         */
        static tFrameNotificationSinkPtr create( FrameNotificationSinkListener& cb )                                                { return create( cb, dvector<FrameTypeInfo>() ); }
        static tFrameNotificationSinkPtr create( FrameNotificationSinkListener& cb, const FrameTypeInfo& type )                     { return create( cb, FrameTypeInfoArray( type ) ); }
        static tFrameNotificationSinkPtr create( FrameNotificationSinkListener& cb, const FrameTypeInfoArray& acceptedFrameTypes )  { return create( cb, acceptedFrameTypes.to_dvector() ); }
    public:
        UDSHL_EXP_API_ ~FrameNotificationSink();

        UDSHL_EXP_API_ bool							isConnected() const;

        /** Returns the frame type of the IFrames generated in this sink and presented in FrameUpdateSinkListener::frameReady
         *
         * @param info	When the information is available, then info is filled with the output frame type of the sink.
         * @return true when the information is available and info was filled with the according data, otherwise false.
         */
        UDSHL_EXP_API_ bool							getOutputFrameType( FrameTypeInfo& info ) const;

        /** Returns eFrameUpdateSink. */
        UDSHL_EXP_API_ tSinkType					getSinkType() const;
    protected:
        UDSHL_EXP_API_ static tFrameNotificationSinkPtr	create( FrameNotificationSinkListener& cb, const dvector<FrameTypeInfo>& acceptedFrameTypes );

        FrameNotificationSink( const FrameNotificationSink& op2 );		// copying disallowed
        void	operator=( const FrameNotificationSink& op2 );

        FrameNotificationSink( FrameNotificationSinkListener& cb, const FrameTypeInfoArray& acceptedFrameTypes );

        smart_ptr<udshl::notification_sink_impl_handle>     impl_;

        // GrabberSinkType virtual functions
        virtual smart_com<icbase::IDShowFilter>		getBaseSinkFilter() const;
        virtual bool	attach( GrabberPImpl* );
        virtual void	detach();
    };
}

#endif // FRAMENOTIFICATIONSINK_H_INC_
