// GrabberSinkType.h: interface for the GrabberSinkType class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_GRABBERSINKTYPE_H__7341AF44_4BE7_42A9_8825_DAE0A0724BA1__INCLUDED_)
#define AFX_GRABBERSINKTYPE_H__7341AF44_4BE7_42A9_8825_DAE0A0724BA1__INCLUDED_

#pragma once

#include "udshl_defs.h"
#include "smart_com.h"

#include "simplectypes.h"
#include "int_interface_pre.h"

namespace _DSHOWLIB_NAMESPACE
{
    /** the available sink types */
    enum tSinkType
    {
        eMEDIASTREAM_SINK = 1,					///< the sink is a type which creates avi/mpeg/... files
        eFRAMEHANDLER_SINK = 2,
        eFRAMENOTIFICATION_SINK = 3,
        eFRAMEQUEUE_SINK = 4,
        eFRAMESNAP_SINK = 5,
    };

	class GrabberPImpl;

	/** Pure virtual base class for all sinks. The currently available sink objects are
	 * MediaStreamSink, FrameHandlerSink and FrameUpdateSink.
	 */
	class GrabberSinkType  
	{
        friend udshl::grabber_backend;
	public:
		/** dtor */
		UDSHL_EXP_API_ virtual ~GrabberSinkType();

		/** must return the sink id*/
		UDSHL_EXP_API_ virtual tSinkType	getSinkType() const = 0;

		//< represents the mode in which the sink currently is
		enum tSinkModes
		{
			eRUN	= 0x1,
			ePAUSE	= 0x2,
			// you cannot set this mode, this is only for the case that no graph is built
			eUNCONNECTED = -1,
		};
		/** sets the mode of the sink.
		 * So by calling this function you can pause and restart the sink.
		 * @return the mode in which the sink is set after the command.
		 */
		UDSHL_EXP_API_ virtual tSinkModes	setSinkMode( tSinkModes mode );
		/** returns the current sink mode */
		UDSHL_EXP_API_ virtual tSinkModes	getSinkMode() const;
		/** Returns if the sink is currently attached to a Grabber */
		UDSHL_EXP_API_ bool		            isAttached() const;
	protected:
		GrabberSinkType();

		virtual bool	attach( GrabberPImpl* );
		virtual void	detach();

		virtual smart_com<icbase::IDShowFilter>			getBaseSinkFilter() const = 0;

		bool		    is_attached_;
	};
};

#endif // !defined(AFX_GRABBERSINKTYPE_H__7341AF44_4BE7_42A9_8825_DAE0A0724BA1__INCLUDED_)
