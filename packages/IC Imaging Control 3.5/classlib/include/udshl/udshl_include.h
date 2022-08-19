#ifndef UDSHL_INCLUDE_H_INC_
#define UDSHL_INCLUDE_H_INC_

#pragma warning( push )
//#pragma warning( disable : 4996 ) // deprecated warnings
#pragma warning( disable : 4786 ) // warning: identifier was truncated (VC6)

namespace _DSHOWLIB_NAMESPACE {}	// define for certain code completion tools

#include <string>
#include <cassert>
#include <vector>
#include <objbase.h>

// DLL public interface 
#include "libbasedefs.h"
#include "udshl_defs.h"

#include "dshow_header.h"

// linker helper, to bind to the UDSHL
#include "udshl_lnk.h"

#include "smart_ptr.h"
#include "smart_com.h"

#include "simplectypes.h"

#include "int_interface_pre.h"

#include "VideoFormatItem.h"
#include "VideoFormatDesc.h"
#include "VideoNormItem.h"
#include "VideoCaptureDeviceItem.h"
#include "AnalogChannelItem.h"

#include "Error.h"
#include "Grabber.h"
#include "MemBufferCollection.h"
#include "MemBuffer.h"
#include "OverlayBitmap.h"
#include "GrabberListener.h"

#include "FrameHandlerSink.h"
#include "MediaStreamSink.h"

#include "IVCDProperty.h"
#include "IVCDPropertyInterfaces.h"

#include "VCDPropertyID.h"

#include "FilterLoader.h"
#include "FrameFilter.h"
#include "FrameFilterImpl.h"
#include "FilterDll.h"
#include "FilterFactory.h"

#include "iframe_def.h"
#include "MediaSampleInfo.h"
#include "MediaSampleInfoDataStore.h"

#include "FrameNotificationSink.h"
#include "FrameQueueSink.h"
#include "FrameSnapSink.h"

#pragma warning( pop )

#endif /* UDSHL_INCLUDE_H_INC_ */
