
#ifndef DEBAYERTRANSFORM_H_INC_
#define DEBAYERTRANSFORM_H_INC_

#pragma once

#include "udshl_defs.h"
#include "int_interface_pre.h"

namespace udshl
{
    struct DeBayerTransformImpl;
}

namespace _DSHOWLIB_NAMESPACE
{
    class GrabberPImpl;

	/** The DeBayerTransform class allows you to control the automatic debayering process of IC Imaging Control. 
	 */
	class DeBayerTransform
	{
        friend udshl::grabber_backend;
	public:
		UDSHL_EXP_API_ ~DeBayerTransform();

		/** Checks whether the image data is currently debayered by IC Imaging Control. */
		UDSHL_EXP_API_
		bool			isActive() const;

		enum tStartPattern
		{
			eBG = 0,
			eGB,
			eGR,
			eRG,
		};

		/** Sets the pattern which determines how the algorithm interprets the pixels of the raw image data.
		 * It has to match the pattern of the first two pixels of the first line. 
		 */
		UDSHL_EXP_API_ 
		void			setStartPattern( tStartPattern pat );
		/** Returns the currently selected start pattern. */
		UDSHL_EXP_API_
		tStartPattern	getStartPattern() const;

		enum tDeBayerMode
		{
			eNearestColor,		///< Simplest and fastest algorithm, but lesser output image quality.
			eBilinear,			///< Algorithm with both acceptable speed and image quality.
			eEdgeSensing,		///< This algorithm creates the best image quality, but is rather slow.
		};

		/** Selects the algorithm for the debayering of the image data. */
		UDSHL_EXP_API_
		void			setDeBayerMode( tDeBayerMode mode );
		/** Returns the currently active debayering algorithm. */
		UDSHL_EXP_API_
		tDeBayerMode	getDeBayerMode() const;
	private:
		DeBayerTransform( udshl::grabber_backend& disp );

        void            notify_graph_post_build( udshl::grabber_backend& obj );
        void            notify_graph_pre_destroy( udshl::grabber_backend& obj );

		udshl::DeBayerTransformImpl*	m_pImpl;
	};
}

#endif // DEBAYERTRANSFORM_H_INC_
