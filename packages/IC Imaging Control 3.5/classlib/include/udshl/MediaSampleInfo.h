
#pragma once

#include "udshl_defs.h"

namespace _DSHOWLIB_NAMESPACE
{
#pragma pack(push,1)
    struct MediaSampleInfo
    {
        enum { static_chunk_id = 'info' };

        uint64_t    driver_frame_number;                // Frame number assigned by the driver, maybe 0 when not supported
        uint64_t    driver_frame_first_packet_time;     // in us, maybe 0 when not supported
        uint64_t    driver_frame_last_packet_time;      // in us, maybe 0 when not supported

        uint64_t	device_time_stamp;	                // this is the timestamp as supplied by the device, maybe 0 if not supported
        uint64_t    device_frame_number;                // this is the frame number as supplied by the device, maybe 0 if not supported.
                                                        // note that this is device dependent. eg. GigECam wraps to 1 after hitting 2 ^ 16

        uint32_t    packet_resends_this_frame;          // only applicable for devices with packet resend, maybe 0 if not supported
        uint32_t    bytes_missing_this_frame;           // number of bytes missing this frame, most likely 0, otherwise this was delivered with DropIncompleteFrames disabled
                                                        // note that the bytes missing can be at the end or in the center depending on the protocol used

        uint32_t    frame_flags;                        // 
    };

    struct MediaSampleInfoMultiFrameSetFrameId
    {
        // This is the multi frame set frame id chunk sent by cameras with IMX174, IMX250, IMX252 sensors
        enum { static_chunk_id = 0x13370002 };

        uint32_t     reserved0 : 28;
        uint32_t     frame_id : 2;
        uint32_t     frame_set : 1;
        uint32_t     reserved1 : 1;
    };
#pragma pack(pop)
}
