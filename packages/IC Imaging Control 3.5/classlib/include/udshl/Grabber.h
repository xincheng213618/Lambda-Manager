// Grabber.h: interface for the Grabber class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_GRABBER_H__F72DCE0B_3C5C_44EA_BFAB_ADDE04304CA6__INCLUDED_)
#define AFX_GRABBER_H__F72DCE0B_3C5C_44EA_BFAB_ADDE04304CA6__INCLUDED_

#pragma once

#include <string>
#include <vector>

#include "udshl_defs.h"
#include "smart_ptr.h"

#include "simplectypes.h"

#include "AnalogChannelItem.h"
#include "VideoNormItem.h"
#include "VideoFormatItem.h"
#include "VideoFormatDesc.h"
#include "VideoCaptureDeviceItem.h"
#include "Error.h"
#include "IVCDProperty.h"
#include "DeBayerTransform.h"
#include "FrameFilterBase.h"

#include "dstring.h"
#include "dvector.h"

namespace _DSHOWLIB_NAMESPACE
{
	class Grabber;
	class MemBufferCollection;
	class MemBuffer;
	class GrabberListener;
	class GrabberSinkType;
	class OverlayBitmap;

	/** This function must be used to initialize the library.
	 * If you want to use a different mode then COINIT_MULTITHREADED, either specify the mode, or call 
     *  InitLibraryWithoutCOM in case you want to Initialize COM yourself (e.g. calling OleInitialize)
     * @param coinit_mode The mode passed into CoInitialize/CoInitializeEx.
	 * @return true on success, false otherwise.
	 */
    UDSHL_EXP_API_ bool	InitLibrary( COINIT coinit_mode = COINIT_MULTITHREADED );

    /** This can be called instead of InitLibrary() when the user wants to initialize COM themselfes.
     * (Calling this does not call CoInitialize/CoInitializeEx.)
     * @return true on success, false otherwise.
     */
    UDSHL_EXP_API_ bool	InitLibraryWithoutCOM();

	/** This function must be used to initialize the library.
	 * @param pSerialNumber		the serial number you want to set
	 * @param coinitmode		mode passed to CoInitializeEx.
	 *				Pass -1 when you already called OleInitialize or CoInitialize/Ex or you bind 
	 *					statically to common dialogs like the file open dialog.
	 *				Pass COINIT_APARTMENTTHREADED if you want to load a common dialog dynamically or when
	 *					some OLE object fails after InitLibrary.
	 * @return true on success, false otherwise.
	 */
    UDSHL_DEPRECATE_FUNCTION_
	UDSHL_EXP_API_ bool	InitLibrary( const char* pSerialNumber, DWORD coinitmode = 0x0 /*COINIT_MULTITHREADED*/ );

	/** This method returns true when all objects returned by the 
	 * the library were destroyed, otherwise false. 
	 * You can use this to determine the best time to unload the library (e.g. for COM objects).
	 */
    UDSHL_DEPRECATE_FUNCTION_
	UDSHL_EXP_API_ bool	CanUnloadLibrary();

	/** This method should be called by the client app, when the library should shut down.
	 * If you don't do this, then the library may seem to leak several objects and bytes, because the dump running
	 * objects call may happen before the library has been told to unload itself.
	 *
	 * After calling ExitLibrary no operation on the library is valid and so its effect is undefined.
	 */
	UDSHL_EXP_API_  void	ExitLibrary();

    /** Function to enable debug tracing 
     * @param level == 0 disabled tracing, level == 0xFFFFFFFF enables all tracing
     */
    UDSHL_EXP_API_  void    LibrarySetLogLevel( DWORD level );


    struct DriverFrameDropInformation 
    {
        /**
         * Frames delivered at the highest driver level before handing of to DirectShow/ICImagingControl
         */
        uint64_t     FramesDelivered;

        /**
         * Frames dropped in the device itself
         */
        uint64_t     FramesDroppedInDevice;
        /**
         * Frames dropped due to incomplete data received, either because of bandwidth problems or problems with the transportation medium
         */
        uint64_t     FramesDroppedDueToPacketLoss;
        /**
         * Frames dropped in the driver, most likely because the system is too slow to transform the images from the transport format into the actual exported format.
         */
        uint64_t     FramesDroppedDueToTransforms;
        /**
         *  Frames dropped due to overrunning queue on the application side. Mostly due to Callbacks taking to much time to copy data from driver buffers into application buffers
         */
        uint64_t     FramesDroppedDueToApplicationQueue;
        /**
         * Frames dropped due to unspecified circumstances (mostly a cop out when the driver does not provide the actual drop info)
         */
        uint64_t     FramesDroppedDueUnspecified;
    };

	class GrabberPImpl;

	/** This class provides the interface to the device.
	 *
	 * Most of the methods return a boolean value. If false or 0 is returned by a method an Error 
	 * may have occurred. You can check this with getLastError(), which returns the last occurred error.
	 *
	 * @see Error
	 **/
	class Grabber
	{
	public:
		UDSHL_EXP_API_ Grabber();
		UDSHL_EXP_API_ ~Grabber();

        /// VideoCaptureDevice (i. e. device)
        typedef VideoCaptureDeviceItem					tVideoCaptureDeviceItem;
        typedef std::vector<tVideoCaptureDeviceItem>	tVidCapDevList;
		/// VideoCaptureDeviceList
		typedef smart_ptr<tVidCapDevList>				tVidCapDevListPtr;

		/// input channel for device
		typedef AnalogChannelItem						tInputChannelItem;
		typedef std::vector<tInputChannelItem>			tInChnList;
		/// list of input channels
		typedef smart_ptr<tInChnList>					tInChnListPtr;

        /// VideoNorm for device
        typedef VideoNormItem							tVideoNormItem;
		typedef std::vector<tVideoNormItem>				tVidNrmList;
		/// VideoNormList
		typedef smart_ptr<tVidNrmList>					tVidNrmListPtr;

        /// VideoFormat for device
        typedef VideoFormatItem							tVideoFormatItem;
		typedef std::vector<tVideoFormatItem>			tVidFmtList;
		/// VideoFormatList
		typedef smart_ptr<tVidFmtList>					tVidFmtListPtr;

		// VideoFormatDescList
		typedef smart_ptr<VideoFormatDesc>				tVidFmtDescPtr;
		typedef std::vector<tVidFmtDescPtr>				tVidFmtDescList;
		typedef smart_ptr<tVidFmtDescList>				tVidFmtDescListPtr;

		/// Memory buffer smart pointer
		typedef smart_ptr<MemBufferCollection>			tMemBufferCollectionPtr;
		/// Memory buffer smart pointer
		typedef smart_ptr<MemBuffer>					tMemBufferPtr;

		/// list of frame rates
		typedef std::vector<double>						tFPSList;
		typedef smart_ptr<tFPSList>						tFPSListPtr;


		/** returns the last error.
		 * when the last call into the library failed, returns the according error structure, else return eNOERROR.
		 * @return the last occurred error
		 */
		UDSHL_EXP_API_
		Error				getLastError() const;


		/** get all available video capture devices in a vector.
		 * @return all available video capture devices in a vector. This may be empty.
         *	On an error 0 is returned.
		 **/
		tVidCapDevListPtr	getAvailableVideoCaptureDevices() const         { return transform_arr_to_ptr_arr( getAvailableVideoCaptureDevices_() ); }

		/** get all available video formats for the current device and current VideoNorm.
		 * @return all available video formats in a vector for the current VideoNorm. This may be empty.
         *	On an error 0 is returned.
		 **/
		tVidFmtListPtr		getAvailableVideoFormats() const                { return getAvailableVideoFormats( getVideoNorm() ); }

		/** get all available video formats for the current device and a given VideoNorm.
		 * @return all available VideoFormats for the given VideoNorm in a vector. This may be empty.
         *	On an error 0 is returned.
		 * @param videonorm videonorm for which the VideoFormats are returned
		 **/
		tVidFmtListPtr		getAvailableVideoFormats( const VideoNormItem& videonorm ) const { return transform_arr_to_ptr_arr( getAvailableVideoFormats_( videonorm ) ); }

		/** test if the device supports video norms
		 * @return true if the device supports video norms
		 **/
		UDSHL_EXP_API_
		bool				    hasVideoNorms() const;

        /** test if the device supports video norms
         * @return true if the device supports video norms
         **/
        bool				    isVideoNormAvailableWithCurDev() const      { return hasVideoNorms(); }

		/** get all supported VideoNorms supported by the device
		 * @return all available VideoNorms in a vector. This may be empty.
         *	On an error 0 is returned.
		 **/
		tVidNrmListPtr			getAvailableVideoNorms() const              { return transform_arr_to_ptr_arr( getAvailableVideoNorms_() ); }

        /** test if the device supports multiple input channels
         * @return true if the device supports multiple input channels
         **/
        UDSHL_EXP_API_
        bool                hasInputChannels() const;

        /** test if the device supports multiple input channels
         * @return true if the device supports multiple input channels
         **/
        bool				isInputChannelAvailableWithCurDev() const       { return hasInputChannels(); }

		/** get all supported input channels
		 * @return all available input channels in a vector. This may be empty.
         *	On an error 0 is returned.
		 **/
		tInChnListPtr		getAvailableInputChannels() const               { return transform_arr_to_ptr_arr( getAvailableInputChannels_() ); }

        /** get current input channel
         * @param channel input channel to set
         * @return true on success, else false
         **/
		UDSHL_EXP_API_
        tInputChannelItem   getInputChannel() const;

        /** set new input channel
         * @param channel new input channel
         * @return true on success, else false
         **/
		UDSHL_EXP_API_
        bool                setInputChannel( const tInputChannelItem& );

        /** set new input channel
         * @param channel new input channel
         * @return true on success, else false
         **/
		UDSHL_EXP_API_
        bool                setInputChannel( DWORD channel );

		/** Opens a video capture device.
		 * @return true on success
		 **/
		UDSHL_EXP_API_
		bool                openDev( const VideoCaptureDeviceItem& dev );

		/** Opens a video capture device.
		 * @return true on success
		 **/
		UDSHL_EXP_API_
		bool                openDev( const char* dev );

		/** gets an item for the currently opened video device
		 * @return the current VideoCaptureDeviceItem, on error an invalid item is returned
		 **/
		UDSHL_EXP_API_
		tVideoCaptureDeviceItem	    getDev() const;

		/** Closes the current opened video capture device.
		* @return true on success
		**/
		UDSHL_EXP_API_
		bool                closeDev();


		/** Test if a device is open
		* @return true, if dev is opened
		**/
		UDSHL_EXP_API_
		bool                isDevOpen() const;

		/** Test if the device is valid (not unplugged)
		 * @return true, if dev is valid, else false if no device is opened or current device is invalid
		 **/
		UDSHL_EXP_API_
		bool				isDevValid() const;

		/** get maximum image size
		* @return maximum image size (width)
		**/
		UDSHL_EXP_API_
		long                getAcqSizeMaxX() const;

		/** get maximum image size
		* @return maximum image size (height)
		**/
		UDSHL_EXP_API_
		long                getAcqSizeMaxY() const;

		/** Start live mode.
		 * This operation may take relatively long and can fail due to many different reasons. So check the error
		 * value after the call of this method.
		 * @param show_videowindow	true to enable the live video window, false to grab only.
		 * @return true on success
		 **/
		UDSHL_EXP_API_
		bool                startLive( bool show_videowindow = true );

		/** stop live mode
		 * @return true on success
		 **/
		UDSHL_EXP_API_
		bool				stopLive();

		/** test of live mode
		 * @return true if live mode is on
		 **/
		UDSHL_EXP_API_
		bool				isLive() const;

		/** get current videonorm
		 * @return current videonorm
		 **/
		UDSHL_EXP_API_
		VideoNormItem		getVideoNorm() const;

		/** set current video norm
		 * @param videonorm videonorm to set as current
		 * @return true on success, else false
		 **/
		UDSHL_EXP_API_
		bool				setVideoNorm( const VideoNormItem& videonorm );

		/** get current videoformat (for acquisition)
		 * @return current videoformat
		 **/
		UDSHL_EXP_API_
		VideoFormatItem		getVideoFormat() const;

		/** set current videoformat (for acquisition)
		 * @param videoformat videoformat to set
		 * @return true on success, else false
		 **/
		UDSHL_EXP_API_
		bool				setVideoFormat( const VideoFormatItem& videoformat );

		/** set Window for live grabbing
		 * @param hwnd window handle for the window to use
		 * @return true on success
		 **/
		UDSHL_EXP_API_
		bool                setHWND( HWND hwnd );


		/** get current HWND for live grabbing
		 * @return null if no handle is set, else the handle
		 **/
		UDSHL_EXP_API_
		HWND                getHWND() const;

		/** flip image horizontal.
		 * @param flip true flip, false do not flip
		 * @return true on success
		 **/
		UDSHL_EXP_API_
		bool				setFlipH( bool flip = true );

		/** get current horizontal flip state
		 * @return current flip state or false if any error occurs
		 * @see setFlip()
		 **/
		UDSHL_EXP_API_
		bool				getFlipH() const;

		/** returns if flip horizontal is available.
		 * @return current flip state or false if any error occurs
		 * @see setFlip()
		 **/
		UDSHL_EXP_API_
		bool				isFlipHAvailable() const;

		/** retrieve the actual frame rate achieved by the device.
		 * the rates describe the time from the start of one frame to the next in milliseconds<br>
		 * only available in live mode
		 */
		UDSHL_EXP_API_
		UDSHL_DEPRECATE_FUNCTION_
		long				getCurrentActualFrameRate() const;

		/** returns if the current device has and may use an external trigger.
		 * <strong>this may return false information for devices, that implement internal trigger support</strong>
		 */
		UDSHL_EXP_API_
		bool				hasExternalTrigger() const;
		/** sets the External Trigger on/off.
		 * only available outside live mode
		 * @param m when true the external trigger is enabled, else disabled.
		 */
		UDSHL_EXP_API_
		bool				setExternalTrigger( bool m );
		/** returns the current setting for the External Trigger.
		 * @return true if it is enabled, else false
		 */
		UDSHL_EXP_API_
		bool				getExternalTrigger() const;

		/** flip image vertical.
		 * @param flip true flip, false do not flip
		 * @return true on success
		 **/
		UDSHL_EXP_API_
		bool				setFlipV( bool flip = true );

		/** get current vertical flip state
		 * @return current flip state or false if any error occurs
		 * @see setFlip()
		 **/
		UDSHL_EXP_API_
		bool				getFlipV() const;

		/** returns if flip vertical is available.
		 * @return current flip state or false if any error occurs
		 * @see setFlip()
		 **/
		UDSHL_EXP_API_
		bool				isFlipVAvailable() const;

		/** sets the position of the video in the live window.
		 * the settings are invalidated by a call to setVideoFormat when getDefaultWindowPosition() == true, otherwise
		 * the settings will not be invalidated by any call to the grabber object.
		 * calling this when the graph is running directly influences the live display.
		 * @param x0 the offset left from the window origin
		 * @param y0 the offset down from the window origin
		 * @return true on success otherwise getLastError() returns the error value.
		 */
		UDSHL_EXP_API_
		bool				setWindowPosition( long x0, long y0  );
		/** sets the  size of the video in the live window.
		 * the settings are invalidated by a call to setVideoFormat when getDefaultWindowPosition() == true, otherwise
		 * the settings will not be invalidated by any call to the grabber object.
		 * calling this when the graph is running directly influences the live display.
		 * @param width the width of the video display in the window. Must be >= 0, otherwise an error is returned.
		 * @param height the height of the video display in the window. Must be >= 0, otherwise an error is returned.
		 * @return true on success otherwise getLastError() returns the error value.
		 */
		UDSHL_EXP_API_
		bool				setWindowSize( long width, long height );
		/** resets the live window position and size to the defaults (x0 = 0, y0 = 0, w = getAcqSizeMaxX(), h = getAcqSizeMaxY() )
		 */
		UDSHL_EXP_API_
		bool				setWindowPosition();
		/** fills the parameters with the current values. */
		UDSHL_EXP_API_
		bool				getWindowPosition( long& x0, long& y0, long& w, long& h ) const;

		/** sets if the window position is reset by a call to VideoFormat.
		 * @param b if b == true then a change of the VideoFormat will change the dimensions */
		UDSHL_EXP_API_
		bool				setDefaultWindowPosition( bool b );
		/** returns if DefaultWindowPosition is set. */
		UDSHL_EXP_API_
		bool				getDefaultWindowPosition() const;

		/**	attaches a new listener object.
		 * @param pListener pointer to the object derived from GrabberListener used as message sink.
		 *			the object pointed to by pListener must live at least as long as the object is registered.
		 * @param reg the callbacks for which the object will be registered. This can be any combination of the flags 
		 *			defined by GrabberListener::tListenerType.
		 *			-1 is interpreted as GrabberListener::eALL.
		 * @return true on success, otherwise false
		 */
		UDSHL_EXP_API_
		bool				addListener( GrabberListener* pListener, DWORD reg = -1 );

		/** removes a listener object for all of the registration values you passed in.
		 * When an entry (pListener,reg) does not exist, the method does nothing for that entry.
		 * When a CB is currently running for one entry removeListener returns false and removing for that entry 
		 * is postponed until the CB returns.
		 *  (You can check if the listener was removed by calling isListenerRegistered).
		 * If no CB is running on the listener object, the entry is removed and the method returns true.
		 * @param pListener pointer to the object derived from GrabberListener which was previously registered.
		 * @param reg the methods may be called by the Grabber object. The flags are defined by GrabberListener::tListenerType.
		 *			-1 is interpreted as GrabberListener::eALL.
		 * @return True when all entries were immediately removed from the list.
		 *			False when one or more entries could not be immediately removed
		 */
		UDSHL_EXP_API_
		bool				removeListener( GrabberListener* pListener, DWORD reg = -1 );

		/** returns if the listener object is registered for any of the passed registration values.
		 * @param pListener the listener to check
		 * @param reg the type for the listener is tested to be registered.
		 * @return true if the listener is registered under any of the types passed in by reg, else false
		 */
		UDSHL_EXP_API_
		bool				isListenerRegistered( GrabberListener* pListener, DWORD reg = -1 );

		/** returns an overlay surfaces which is rendered into the stream */
		UDSHL_EXP_API_
        UDSHL_DEPRECATE_FUNCTION_T_( "Grabber::getOverlay( tPathPosition ) method" )
		smart_ptr<OverlayBitmap>	getOverlay() const;

		/** set the format of the sink.
		 * @param pNewSink the new sink type
		 * @return true on success
		 */
		UDSHL_EXP_API_
		bool				setSinkType( const smart_ptr<GrabberSinkType>& pNewSink );

		/** returns the current reference time in 100 nanoseconds (or 1/10000 milliseconds).
		 * the value depends on the ReferenceClock used in the graph (but is mostly equivalent to QueryPerformanceCounter).
		 * the method fails when no reference clock is available.
		 * @param Current gets the value of the current reference time.
		 * @return true on success, otherwise false and an error value is set.
		 */
		UDSHL_EXP_API_
		bool				getCurReferenceTime( int64_t& Current ) const;
		/** returns the reference time used when the graph was started in 100 nanoseconds (or 1/10000 milliseconds).
		 * the value depends on the ReferenceClock used in the graph (but is mostly equivalent to QueryPerformanceCounter).
		 * the method fails when no reference clock is available.
		 * @param GraphStart gets the value of the reference start time of the graph.
		 * @return true on success, otherwise false and an error value is set.
		 */
		UDSHL_EXP_API_
		bool				getGraphStartReferenceTime( int64_t& GraphStart ) const;

		UDSHL_EXP_API_
		smart_com<IVCDPropertyItems>	getAvailableVCDProperties() const;

		/** Returns if a device supports querying if a video stream is available for the device.
         * Certain devices which capture video from analog video capture devices have this property.
		 * @return true/false
		 */
        UDSHL_EXP_API_
        bool				hasSignalDetected() const;

        //UDSHL_DEPRECATE_FUNCTION_T_( "Grabber::hasSignalDetected()" )
		bool				isSignalDetectedAvailable() const       { return hasSignalDetected(); }

		/** returns if a signal was detected by the device. This flag is only thought for devices 
		 * which get a signal from an external device, e.g. a converter which gets its video
		 * from a analog camera.
		 * @return true the driver of the device said that a signal was detected. false when 
		 * either the driver said no signal was detected or when an error occurred 
		 * (e.g. option not available).
		 */
		UDSHL_EXP_API_
		bool				getSignalDetected() const;

        /**Returns if the device has a FPS list.
         * \return true if FPS settings are available, otherwise false
         */
        UDSHL_EXP_API_
        bool				hasFPSList() const;
        UDSHL_EXP_API_
        bool				hasFPSList( const VideoFormatItem& op ) const;

        /** Returns if the device supports a list of frame rates, which the user can set.
         * @return	true/false
         */
        bool				isFrameRateListAvailable() const { return hasFPSList(); }
        bool				isFrameRateListAvailable( const VideoFormatItem& op ) const { return hasFPSList( op ); }

		/** Returns the FPS list available for this videoformat.
		 * The entries describe the count of frames per second generated. 
		 */
		tFPSListPtr	        getAvailableFPS( const VideoFormatItem& op ) const { return transform_arr_to_ptr_arr<double>( getAvailableFPS_( op ) ); }

		/** Returns the frame rates available for the current videoformat.
         * The entries describe the count of frames per second generated.
         */
		tFPSListPtr	        getAvailableFPS() const { return getAvailableFPS( getVideoFormat() ); }

		/** Retrieve the actual frame rate achieved by the device.
         * Note: this number is generated by the driver of the device, but may be 0 when the driver does not support this feature.
		 */
		UDSHL_EXP_API_
        UDSHL_DEPRECATE_FUNCTION_
		double				getCurrentActualFPS() const;

		/** Returns the current maximal fps the device can achieve on the bus.
		 * This may be different from the maximal fps in the fps list, due to several devices which run 
		 * on the same bus and have to share the bandwidth.
		 * If you set a higher frame rate than the one returned by this function, the call to startLive may
		 * fail because the device cannot be started at the rate. This leads to the error "Failed to connect
		 * the pins."
		 * @return The FPS. This may be 0 when the device does not support this property or cannot supply it
		 *			in the current mode of operation.
		 *			(some devices need to be started to retrieve this setting (this is a bit odd in some drivers ;-) )
		 */
		UDSHL_EXP_API_
        UDSHL_DEPRECATE_FUNCTION_
        double				getCurrentMaxAvailableFPS() const;

		/** sets the frame rate to achieve by the device.
		 * only available outside live mode
		 */
		UDSHL_EXP_API_
		bool				setFPS( double fps );
		/** gets the frame rate which is currently set.
		 */
		UDSHL_EXP_API_
		double				getFPS() const;

		/** Returns if the device supports retrieving the current dropped frames counter.
		 * @return true/false
		 */
        bool				isCountOfFramesDroppedAvailable() const { return hasCountOfFrames(); }

        UDSHL_EXP_API_
        bool				hasCountOfFrames() const;

		/**	Returns the number of frames dropped by the VideoCaptureDevice.
		 * @return The number of frames dropped by the VideoCaptureDevice.
		 *			May be == 0 when the device does not export this property.
		 */
		UDSHL_EXP_API_
		long				getCountOfFramesDropped() const;

		/** Returns the number of frames the VideoCaptureDevice send, which were not dropped by the device.
		 * This doesn't mean these frames were delivered, because some frames can be dropped along the way.
		 * @return The number of frames not dropped by the VideoCaptureDevice.
		 *			May be == 0 when the device does not export this property.
		 */
		UDSHL_EXP_API_
		long				getCountOfFramesNotDropped() const;

		/** Sets the pause mode.
		 * In live mode the video is immediately paused. Outside live mode the mode is saved and will be set
		 * when a startLive is called.
		 * @return true on success, otherwise false.
		 */
		UDSHL_EXP_API_
		bool				setPauseLive( bool on );
		/** Returns if the pause mode is enabled.
		 * @return true when the pause mode is enabled.
		 */
		UDSHL_EXP_API_
		bool				getPauseLive() const;

		/** Shows the property page for this device.
		 * \param title		The title to show.
		 * \param hParent	The parent window of this property page. If this is 0, then the active window is used
		 *						because the page needs to be modal!!
		 * \return true on success, otherwise false.
		 */
		UDSHL_EXP_API_
		bool				showVCDPropertyPage( HWND hParent = 0, const dstringa& title = "" );
		UDSHL_EXP_API_
		bool				showVCDPropertyPage( HWND hParent, const dstringw& title );

		/** Shows a device settings page to choose a device and several other options for this device.
		 * \param hParent	The parent of this modal page. If this is 0, then the active window is used
		 *						because the page needs to be modal!!
		 * \param excludeDevices	A vector containing names of the devices that are not displayed in the
		 *					device selection combo box. This is useful to hide devices that are already opened by
		 *					the calling application.
		 * \return true when the user clicked OK to exit the page, false if he clicked CANCEL or an error occurred.
		 */
		UDSHL_EXP_API_
		bool				showDevicePage( HWND hParent = 0 );
		bool				showDevicePage( HWND hParent, const std::vector<std::string>& excludeDevices )
		{
			dvector<dstringw> lst;
			for( size_t i = 0; i < excludeDevices.size(); ++i ) {
				lst.push_back( astows( excludeDevices[i] ) );
            }
			return showDevicePage_( hParent, lst );
		}
		bool				showDevicePage( HWND hParent, const std::vector<std::wstring>& excludeDevices )
		{
			return showDevicePage_( hParent, dvector<dstringw>( excludeDevices.begin(), excludeDevices.end() ) );
		}

		UDSHL_EXP_API_
		bool				openDev( const dstringa& devstring );
		UDSHL_EXP_API_
		bool				openDev( const dstringw& devstring );
		UDSHL_EXP_API_
		bool				openDev( int64_t serial );
		UDSHL_EXP_API_
		bool				setVideoFormat( const dstringa& videoformatstring );
		UDSHL_EXP_API_
		bool				setVideoFormat( const dstringw& videoformatstring );
		UDSHL_EXP_API_
		bool				setVideoNorm( const dstringa& videonormstring );
		UDSHL_EXP_API_
		bool				setVideoNorm( const dstringw& videonormstring );
		UDSHL_EXP_API_
        bool                setInputChannel( const dstringa& inputchannel );
		UDSHL_EXP_API_
		bool                setInputChannel( const dstringw& inputchannel );

		UDSHL_EXP_API_
		bool				openDevByUniqueName( const dstringa& unique_name );
		UDSHL_EXP_API_
		bool				openDevByUniqueName( const dstringw& unique_name );
		UDSHL_EXP_API_
		bool				openDevByDisplayName( const dstringa& display_name );
		UDSHL_EXP_API_
		bool				openDevByDisplayName( const dstringw& display_name );
		
		/** Restores a saved grabber state */
		UDSHL_EXP_API_
		bool			loadDeviceState( const dstringa& xmlStr, bool bOpenDev = true );
		UDSHL_EXP_API_
		bool			loadDeviceState( const dstringw& xmlStr, bool bOpenDev = true );

		/** Saves the grabber state to a file */
		UDSHL_EXP_API_
		bool			saveDeviceStateToFile( const dstringa& filename ) const;
		UDSHL_EXP_API_
		bool			saveDeviceStateToFile( const dstringw& filename ) const;

		/** Loads the grabber state from a file */
		UDSHL_EXP_API_
		bool			loadDeviceStateFromFile( const dstringa& filename, bool bOpenDev = true );
		UDSHL_EXP_API_
		bool			loadDeviceStateFromFile( const dstringw& filename, bool bOpenDev = true );

		/** sets the position of the OverlayBitmap in the graph.
		 * You can set the position before calling startLive, when the graph is running you cannot change the position.
		 * The Graph position is saved as long as the grabber object instance lives and is not invalidated by closing
		 * the current device.
		 * @see tPathPosition for the available positions the overlay bitmap can take in the graph.
		 * @param OVBPathPositions An or'ed value which contains all path positions which should be enabled.
		 * @return true on success, otherwise false and getLastError returns an error description.
		 */
		UDSHL_EXP_API_
		bool				setOverlayBitmapPathPosition( uint32_t OVBPathPositions );
		/** returns the current position of the OverlayBitmap in the graph.
		 * @see tPathPosition for the available positions the overlay bitmap can take in the graph.
		 * @return true on success, otherwise false and getLastError returns an error description.
		 */
		UDSHL_EXP_API_
		uint32_t				getOverlayBitmapPathPosition() const;

		/** Returns a pointer to the current sink.
		 * @return NULL when no sink is set.
		 */
		UDSHL_EXP_API_
		smart_ptr<GrabberSinkType>	getSinkTypePtr() const;

		/** This methods allow fine grained control over what is saved to the string/file.
		 * @param bDevice				If the device should be saved
		 * @param bGrabberDeviceSetup	If the following device settings should be saved:
		 *		<ul>
		 *			<li>Video norm</li>
		 *			<li>Video format</li>
		 *			<li>Input Channel</li>
		 *			<li>FPS</li>
		 *			<li>FlipH/V</li>
		 *			<li>VCRCompatibility</li>
		 *		</ul>
		 * @param bVCDProperties		If the VCDProperties should be saved
		 * @return the string.
		 */
		std::string		saveDeviceState( bool bDevice = true, bool bGrabberDeviceSetup = true, bool bVCDProperties = true ) const
		{
			return wstoas( saveDeviceState_( bDevice, bGrabberDeviceSetup, bVCDProperties ) );
		}
		std::wstring		saveDeviceStateW( bool bDevice = true, bool bGrabberDeviceSetup = true, bool bVCDProperties = true ) const
		{
			return saveDeviceState_( bDevice, bGrabberDeviceSetup, bVCDProperties);
		}

		UDSHL_EXP_API_
		bool			saveDeviceStateToFile( const dstringa& filename, bool bDevice, bool bGrabberDeviceSetup = true, bool bVCDProperties = true ) const;
		UDSHL_EXP_API_
		bool			saveDeviceStateToFile( const dstringw& filename,bool bDevice, bool bGrabberDeviceSetup = true, bool bVCDProperties = true ) const;

		/** Sets one device frame filter for the grabber. You can only set filters when the graph is stopped.
		 * These new frame filters will be placed right behind the VideoCaptureDevice.
		 *
		 * Any previous installed frame filters are removed.
		 * If you pass in 0, no new frame filter will be installed.
		 * @param pFrameFilter The new frame filter you want to use. This must not be deleted
		 *				while it is set in the grabber.
		 * @return true on success, false otherwise.
		 */
		UDSHL_EXP_API_
		bool					setDeviceFrameFilters( IFrameFilter* pFrameFilter );

		/** Sets one or more device frame filters for the grabber. You can only set filters when the graph is stopped.
		 * These new frame filters will be placed right behind the VideoCaptureDevice.
		 *
		 * Any previous installed frame filters are removed.
		 * If you pass an empty list, no new frame filter will be installed.
		 * @param lst The new frame filters you want to use. These must not be deleted
		 *				while they are set in the grabber.
		 * @return true on success, false otherwise.
		 */
		bool					setDeviceFrameFilters( const tFrameFilterList& lst )    { return setDeviceFrameFilters_( to_dvector( lst ) ); }

		/** Returns a list of frame filters set by setDeviceFrameFilters.
		 * @return Either the list of currently set frame filters, or an empty list when no frame filters are set.
		 */
		const tFrameFilterList	getDeviceFrameFilters() const                           { return to_vector( getDeviceFrameFilters_() ); }

		/** Returns the actual dimension of the data which is passed to the video window.
		 * This may be different from the VideoFormat, when you use DeviceFrameFilters/DisplayFrameFilters and
		 * it may be different from the FrameHandlerSink dimensions.
		 *
		 * You can only retrieve this information, when the graph is already built.
		 * @param dim	Will be filled with the dimension of the video data stream, which arrives at the VideoRenderer.
		 * @return true when dim could be filled with the actual dimensions, otherwise false.
		 */
		UDSHL_EXP_API_
		bool			getVideoDataDimension( SIZE& dim ) const;

		/** Tries to create the graph and then disconnects the VideoCaptureDevice.
		 * You can use this to save time when building the graph.
		 *
		 * No operation which may change the graph layout is permitted after prepareLive is called.
		 *
		 *	So following operations are not permitted :
		 *		<ul>
		 *			<li>setVideoFormat</li>
		 *			<li>setFrameRate/setFPS</li>
		 *			<li>setVideoNorm</li>
		 *			<li>setSinkType</li>
		 *			<li>setOverlayBitmapPathPosition</li>
		 *			<li>setTrigger</li>
		 *			<li>setFlipH/V</li>
		 *			<li>...</li>
		 *		</ul>
		 *
		 *	The methods stopLive and closeDev end this mode.
		 *
		 * @param	bUseVideoRenderer	If a VideoRenderer should be used. @see Grabber::startLive.
		 * @return	true on success, otherwise false.
		 */
		UDSHL_EXP_API_
		bool			prepareLive( bool bUseVideoRenderer );
		/** Returns if the graph is prepared, but not yet started.
		 * @return true/false.
		 */
		UDSHL_EXP_API_
		bool			isLivePrepared() const;
		/** Suspends a running graph.
		 * A running graph so gets prepared.
		 *
		 * When the operation fails, the graph is set to the stopped state.
		 * @return true on success, otherwise false.
		 */
		UDSHL_EXP_API_
		bool			suspendLive();

		/** Sets one display frame filter for the grabber. You can only set filters when the graph is stopped.
		 * These new frame filters will be placed right in front of the VideoRenderer.
		 *
		 * Any previous installed frame filters are removed.
		 * If you pass in 0, no new frame filter will be installed.
		 * @param pFrameFilter The new frame filter you want to use. This must not be deleted
		 *				while it is set in the grabber.
		 * @return true on success, false otherwise.
		 */
		UDSHL_EXP_API_
		bool					setDisplayFrameFilters( IFrameFilter* pCB );

		/** Sets one or more device frame filters for the grabber. You can only set filters when the graph is stopped.
		 * These new frame filters will be placed right in front of the VideoRenderer.
		 *
		 * Any previous installed frame filters are removed.
		 * If you pass an empty list, no new frame filter will be installed.
		 * @param lst The new frame filters you want to use. These must not be deleted
		 *				while they are set in the grabber.
		 * @return true on success, false otherwise.
		 */
		bool					setDisplayFrameFilters( const tFrameFilterList& lst )   { return setDisplayFrameFilters_( dvector<IFrameFilter*>( lst.begin(), lst.end() ) ); }

		/** Returns a list of frame filters set by setDeviceFrameFilters.
		 * @return Either the list of currently set frame filters, or an empty list when no frame filters are set.
		 */
		const tFrameFilterList	getDisplayFrameFilters() const                          { return to_vector( getDisplayFrameFilters_() ); }

		/** Returns the control interface for the DeBayerTransform filter, which may be used in
		 * the grabber to implicitly debayer a stream.
		 * @return should never be 0,
		 */
		UDSHL_EXP_API_
		smart_ptr<DeBayerTransform>	getDeBayerTransform() const;

		/** This method fetches the according OVB from the internal list of usable OVB objects.
		 * @param PathPositionToFetch The position of the OVB to fetch.
		 * @return 0 if an invalid index was passed, otherwise the according object.
		 */
		UDSHL_EXP_API_
		smart_ptr<OverlayBitmap>	getOverlay( tPathPosition PathPositionToFetch ) const;

		/** Retrieves the list of interfaces, retrieved from the graph.
		 * This should be used with caution, as not to hold things, you shouldn't keep open.
		 *
		 *	Beware, that this method does not set the last error var.
		 * \param itf_guid	The IID of the interfaces to retrieve.
		 * \param vec		List, where the interfaces will be added to.
		 * \return false, when no graph is build, etc.
		 */
		typedef dvector<smart_com<IUnknown> > tGraphItfList;
		UDSHL_EXP_API_
		bool	            getGraphInterfaceList( const GUID& itf_guid, tGraphItfList& vec );

		tVidFmtDescListPtr	getAvailableVideoFormatDescs() const                                    { return getAvailableVideoFormatDescs( getVideoNorm() ); }
		tVidFmtDescListPtr	getAvailableVideoFormatDescs( const VideoNormItem& videoNorm ) const    { return transform_arr_to_ptr_arr( getAvailableVideoFormatDescs_( videoNorm ) ); }

		/** Returns if the I2C interface is supported by the device.
		 *	\return true when the device supports the interface, false when either an error occurred or the device does not support I2C
		 */
		UDSHL_EXP_API_
		bool		hasI2CInterface();

        /** Reads data from the device at dev_addr. This is device specific.
		 * \param dev_addr		The address of the I2C client on the device which should be queried for data.
         * \param write_buffer	The write buffer. This must be at least write_len bytes.
		 * \param write_len	    The length of the data to write. Maybe 0
		 * \param read_buffer	Buffer to receive the data read from the bus. This must be at least read_len bytes.
         * \param read_len		The amount of bytes that should be read on the bus.
		 * \return true on success, otherwise false
		 */
		UDSHL_EXP_API_
		bool		execI2COperation( int dev_addr, void* write_buffer, int write_len, void* read_buffer, int read_len );

        /** Reads the frame drop information from the underlying driver if available.
         * \return true on success, false if the information is not available.
         */
        UDSHL_EXP_API_
        bool        getDriverFrameDropInformation( DriverFrameDropInformation& info );

        UDSHL_EXP_API_
        tIVCDPropertyItemPtr        getVCDPropertyItem( const GUID& item_id );
        UDSHL_EXP_API_
        tIVCDPropertyElementPtr     getVCDPropertyElement( const GUID& item_id, const GUID& elem_id );
        UDSHL_EXP_API_
        tIVCDPropertyInterfacePtr   getVCDPropertyInterface( const GUID& item_id, const GUID& elem_id, const GUID& itf_id );

        template<class TItf>
        smart_com<TItf>             getVCDPropertyInterface( const GUID& item_id, const GUID& elem_id )
        {
            tIVCDPropertyElementPtr ptr = getVCDPropertyElement( item_id, elem_id );
            if( ptr == NULL ) {
                return NULL;
            }
            return ptr->getInterfacePtr<TItf>();
        }
    private:
        Grabber( const Grabber& );
        Grabber& operator=( const Grabber& );

        template<class T>
        smart_ptr<std::vector<T>>    transform_arr_to_ptr_arr( const dvector<T>& v ) const
        {
            if( v.empty() && getLastError().isError() )
            {
                return NULL;
            }
            return new std::vector<T>( v.begin(), v.end() );
        }

		UDSHL_EXP_API_
		dvector<VideoNormItem>          	getAvailableVideoNorms_() const;

		UDSHL_EXP_API_
		dvector<AnalogChannelItem>		    getAvailableInputChannels_() const;

		UDSHL_EXP_API_
		dvector<VideoFormatItem>	    getAvailableVideoFormats_( const VideoNormItem& item ) const;

		UDSHL_EXP_API_
		dvector<double>			        getAvailableFPS_( const VideoFormatItem& op ) const;

		UDSHL_EXP_API_
		bool				            showDevicePage_( HWND hParent, const dvector<dstringw>& excludeDevices );

		UDSHL_EXP_API_
		dstringw		                saveDeviceState_( bool bDevice, bool bGrabberDeviceSetup = true, bool bVCDProperties = true ) const;

		UDSHL_EXP_API_
		bool					        setDeviceFrameFilters_( const dvector<IFrameFilter*>& lst );

		UDSHL_EXP_API_
		dvector<IFrameFilter*>	        getDeviceFrameFilters_() const;

		UDSHL_EXP_API_ 
		dvector<VideoCaptureDeviceItem>	        getAvailableVideoCaptureDevices_() const;

		UDSHL_EXP_API_
		dvector<smart_ptr<VideoFormatDesc> >	getAvailableVideoFormatDescs_( const VideoNormItem& videoNorm) const;

		UDSHL_EXP_API_
		dvector<IFrameFilter*>	        getDisplayFrameFilters_() const;

		UDSHL_EXP_API_
		bool					        setDisplayFrameFilters_( const dvector<IFrameFilter*>& lst );

		GrabberPImpl*		m_pP;
	};
}

#endif // !defined(AFX_GRABBER_H__F72DCE0B_3C5C_44EA_BFAB_ADDE04304CA6__INCLUDED_)
