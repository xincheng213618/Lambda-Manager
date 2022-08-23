
#ifndef SIMPLECTYPES_H_INC
#define SIMPLECTYPES_H_INC

#include "libbasedefs.h"

typedef long long REFERENCE_TIME;

#ifndef MAKEFOURCC
    #define MAKEFOURCC(ch0, ch1, ch2, ch3)                              \
                ((DWORD)(BYTE)(ch0) | ((DWORD)(BYTE)(ch1) << 8) |   \
                ((DWORD)(BYTE)(ch2) << 16) | ((DWORD)(BYTE)(ch3) << 24 ))
#endif //defined(MAKEFOURCC)

namespace _DSHOWLIB_NAMESPACE
{
	/** the possible error types */
	enum tErrorEnum
	{
		eNOERROR = 0,							    //< no error occurred
		eUNKNOWN = 1,							    //< an unknown error occurred

		eDSHOWLIB_EXCEPTION = 2,				    //< an unexpected DShowLibException occurred, please contact the producer's support

		eOUT_OF_MEMORY = 4,						    //< out of memory
		eWRITE_ERROR = 5,						    //< an error occurred while writing #TODO maybe replace with eFILE_FAILED_TO_WRITE_DATA
		eNO_VIDEO_HARDWARE_FOUND = 6,			    //< no video hardware found on this system

		eINVALID_PARAM_VAL = 7,					    //< an invalid parameter was passed in
		eNO_CURRENT_VALUE = 9,					    //< no current value for setting is available
		eINVALID_MEMBUFFER = 10,				    //< the MemBuffer is not compatible to the grabber format or the MemBuffer is not valid
		eMODE_ALREADY_ACTIVE = 11,				    //< the requested mode is already the active one, we cannot switch
		eNO_DEVICE_OPENED = 12,					    //< no device opened, please open one to operate
		eDEVICE_INVALID = 13,					    //< the device has become invalid (e. g. it was unplugged)
		eDEVICE_NOT_FOUND = 16,						//< the device was not found

		eFUNC_NOT_AVAIL_IN_LIVEMODE = 19,			//< this function cannot be called if live mode is active
		eFUNC_ONLY_AVAIL_IN_LIVEMODE = 20,			//< this function cannot be called if live mode is not active
		eVIDEOFORMAT_INVALID = 24,					//< the current VideoFormat is invalid
		eTIMEOUT_PREMATURLY_ELAPSED = 27,			//< the timeout passed to snapImages( ... ) did elapse before all images could be snapped

		ePASSED_DATA_DOES_NOT_FIT_TO_COMPRESSOR = 28,	//< the data passed to the AviSink does not fit to the Compressor

		eOPTION_NOT_AVAILABLE = 29,					//< an option is not available, e.g. you called setFlipH and the VideoCaptureDevice does not support flipping
		eINCOMPLETE = 34,							//< The operation was only partially successful, e.g. not all properties of the grabber could be restored

		eFILENOTFOUND = 35,
        eFILE_COULD_NOT_CONVERT_FRAMETYPE_TO_FILETYPE = 36, //> Failed to convert IFrame type to a type which can be saved in a BMP file
        eFILE_FAILED_TO_WRITE_DATA = 37,                    //< Failed to write data to a file
        eSINK_NOT_CONNECTED = 38,                           //< Sink is not yet connected.
        eSINK_FRAMETYPE_MISMATCH = 39,                      //> The passed buffer does not have a matching FrameType to the sink
        eSINK_ALREADY_ATTACHED = 40,                        //> The sink passed in is already attached to another graph
        eSINK_WRONG_MODE = 41,                              //> The sink is currently not in the correct mode to complete this action.

        eSTREAM_FAILED_TO_START_PREPARED_STREAM = 42,
        eSTREAM_FAILED_TO_CHANGE_PAUSE_STATE = 43,
        eSTREAM_VIDEOCAPTURE_DEVICE_ALREADY_IN_USE = 44,

        eFAILED_TO_RETRIEVE_VIDEOFORMATS = 45,              //> The library was unable to retrieve a valid videoformat list from the device.


#if 1   // currently deprecated error defines
        eUNEXPECTED_DSHOWLIB_BEHAVIOUR = 3,		    //< DShowLib behaves unexpected, please contact the producer's support

        eAUTOMATION_ENABLED = 8,				    ///< automation is enabled for given property, could not set/get value
        eDRIVER_INSTALLATION = 14,				    ///< driver component not found; please check your driver installation
        eNOT_AVALILABLE_WITH_CURRENT_DEVICE = 15,	///< the called function is not available with currently set device
        eAUTOMATION_NOT_AVAILABLE = 17,				///< automation is not available for the given property
        eITEM_DOES_NOT_FIT_TO_DEV = 18, 			///< the given item does not fit to the current device (currently not used)
        eNOT_INITIALIZED = 21,                       ///< the object is not initialized
        eNO_FRAMEGRABBER_SINK = 22,					///< a function was called, which relies on having a FrameGrabberSink as sink_type
        eSERIALNUMBER_INVALID = 23,					///< the serial number is invalid
        eUNEXPECTED_SINKFORMAT_CHANGE = 25,			///< during building the filter graph, the sink format changed unexpectedly and the MemBufferCollection got invalid to this new format
        eNO_EXTERNALTRANSPORT_AVAILABLE = 26,		///< getETMode() and setETMode() don't function without an ExternalTransport capable device

        eCOMPONENT_NOT_FOUND = 30,					///< a component of the installation was not found, please check your installation

        eINCOMPATIBLE_VERSION = 32,				    ///< the version of the data format passed to the function is incompatible with the function

        eNO_CODECS_FOUND = 31,						///< no codec installed on this system
        eREAD_ERROR = 33,							///< an error occurred while trying to read data from a file
#endif
        //ePARAM_NOT_FOUND = 1001,                    //< used in tFilterError enumeration
        //eINCOMPATIBLE_PARAM_VALUE = 1002,           //< used in tFilterError enumeration
        //eINVALID_FILTER_STATE = 1003,               //< used in tFilterError enumeration
    };


	/** possible OutputColorformats
	**/
	typedef enum
	{
		eInvalidColorformat = 0,	///< invalid color format (do not use !!)
		eRGB32 = 1,					///< 32 bit BGRA
		eRGB24,						///< 24 bit BGR
        //UDSHL_DEPRECATE_FUNCTION_TEXT_( "RGB32 type for better performance and images. )
		eRGB565,					///< 5-6-5 BGR, 16 bit
        //UDSHL_DEPRECATE_FUNCTION_TEXT_( "RGB32 type for better performance and images. )
		eRGB555,					///< 5-5-5 BGR, 16 bit
        //UDSHL_DEPRECATE_FUNCTION_T_( "Y800 type for better performance and images." )
		eRGB8,						///< 8 bit grey
		eY8 = eRGB8,				///< because of old versions, eY8 and eRGB8 are equal
		eUYVY,						///< 16 bit YUV format layout U0Y0V0Y1, top down
		eY800,						///< 8 bit Y format, top down (this means no transformation between input Y800 and 
									///< the sink is needed)
        //UDSHL_DEPRECATE_FUNCTION_T_( "native types the camera delivers, like Y16 when available." )
		eYGB1,						///< 16 bit Y (10 bit valid) grey, top down, bits ordered per pixel [76543210______98],
									/** Algorithm for converting this layout to eY800 :
										BYTE convYGB1toY8( __int16 y )
										{
											BYTE* p = (BYTE*) &y;
											unsigned __int16 x = ((unsigned int)p[0] << 8) | p[1];
											return (BYTE) ((x >> 2) & 0xFF );
										}
									*/
        //UDSHL_DEPRECATE_FUNCTION_T_( "native types the camera delivers, like Y16 when available." )
		eYGB0,						///< 16 bit Y (10 bit valid) grey, top down, bits ordered per pixel [10______98765432],
									/** Algorithm for converting this layout to eY800 :
										BYTE convYGB0toY8( __int16 y )
										{
											return (BYTE) (y & 0xFF);
										}
									*/
		eBY8,						///< Bayer Y800 Format
		eY16,						///< 16-bit gray, top down. Each pixel is represented by an unsigned 16 bit integer (unsigned short, uint16_t)
									/** Algorithm for converting this layout to eY800 :
										BYTE convY16toY8( uint16_t y )
										{
											return (BYTE) (y >> 8);
										}
									*/
        eRGB64,                     ///* build the same as RGB32 but each factor is now 16 bit
	} tColorformatEnum;


	/// Mask for RGB565-Format
	typedef enum
	{
		eRGB565_R = 0xf800, ///< Mask for blue	(1111100000000000)
		eRGB565_G = 0x07e0, ///< Mask for green	(0000011111100000)
		eRGB565_B = 0x001f, ///< Mask for red	(0000000000011111)
	} RGB565Mask;

	/// Mask for RGB555-Format
	typedef enum
	{
		eRGB555_R = 0x7c00, ///< Mask for blue	(0111110000000000)
		eRGB555_G = 0x03e0, ///< Mask for green	(0000001111100000)
		eRGB555_B = 0x001f, ///< Mask for red	(0000000000011111)
	} RGB555Mask;

	/// Enumeration of frame type. Member of tsMediaSampleDesc.
	typedef enum
	{
		eFRAME_INTERLEAVED = 0,		///< interleaved frame
		eFRAME_FIELD1 = 1,			///< the first field of a frame
		eFRAME_FIELD2 = 2,			///< the second field of a frame
	} tFrameDesc;

	/** Graph positions
	* the graph most likely will look like this :
	*
	* VCD -> x1 -> tee filter	-> x2	-> sink
	*							-> x3	-> renderer
	*
	* The positions marked with x(n) can be configured by the following enum
	*/
	typedef enum
	{
		ePP_NONE = 0x0,
		ePP_DEVICE = 0x1,				///< x1, directly behind the source
		ePP_SINK = 0x2,					///< x2, directly in front of a frame grabber sink/codec
		ePP_DISPLAY = 0x4,				///< x3, directly in front of the video renderer
	} tPathPosition;

	/// Structure describing the properties of a frame (e.g. a MemBuffer)
	typedef struct tsMediaSampleDesc
	{
		int64_t	        SampleStart;		///< the start time of the sample as set by the video capture device
        int64_t	        SampleEnd;			///< the end time of the sample as set by the video capture device
		unsigned int	FrameNumber;		///< the frame number of the sample as set by the video capture device
											///< the device does not need to set this field, or keep it updated
		tFrameDesc		FrameType;			///< the type of the frame
	} tsMediaSampleDesc;

	/** Public subtypes which you can use in applications.
	 * Other common subtypes (which are included by the directshow headers) are :
		MEDIASUBTYPE_RGB32
		MEDIASUBTYPE_RGB24
		MEDIASUBTYPE_RGB565
		MEDIASUBTYPE_RGB555
		MEDIASUBTYPE_RGB8
		MEDIASUBTYPE_UYVY
		MEDIASUBTYPE_YUY2
		...

	 * When you want to create your own subtypes, then you need to only alter the first DWORD, which is the 
	 * String Representation of your FourCC.
	 * You may also create your completely own GUIDs which do not correspond to FourCCs, but then no string
	 * representation can be given by the library.
	 */
	static const GUID MEDIASUBTYPE_Y800 =	{ MAKEFOURCC('Y','8','0','0'), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71 };
	static const GUID MEDIASUBTYPE_Y8 =		{ MAKEFOURCC('Y','8',' ',' '), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71 };
	static const GUID MEDIASUBTYPE_BY8 =	{ MAKEFOURCC('B','Y','8',' '), 0x0000, 0x0010, { 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71 } };
	static const GUID MEDIASUBTYPE_YGB0 =	{ MAKEFOURCC('Y','G','B','0'), 0x0000, 0x0010, { 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71 } };
	static const GUID MEDIASUBTYPE_YGB1 =	{ MAKEFOURCC('Y','G','B','1'), 0x0000, 0x0010, { 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71 } };
	static const GUID MEDIASUBTYPE_YUY2 =	{ MAKEFOURCC('Y','U','Y','2'), 0x0000, 0x0010, { 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71 } };
	static const GUID MEDIASUBTYPE_Y16 =	{ MAKEFOURCC('Y','1','6',' '), 0x0000, 0x0010, { 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71 } };	
    static const GUID MEDIASUBTYPE_YUV16PLANAR = { MAKEFOURCC( 'Y', 'U', 'G', 'p' ), 0x0000, 0x0010, { 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71 } };
    static const GUID MEDIASUBTYPE_RGB64 = { MAKEFOURCC( 'R', 'G', 'B', '6' ), 0x0000, 0x0010, { 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71 } };
}

#endif /* SIMPLECTYPES_H_INC */
