// AnalogChannelItem.h: interface for the AnalogChannelItem class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_ANALOGCHANNELITEM_H__31CEA1C4_246E_411C_800F_CF94EE0DBE8D__INCLUDED_)
#define AFX_ANALOGCHANNELITEM_H__31CEA1C4_246E_411C_800F_CF94EE0DBE8D__INCLUDED_

#pragma once

#include "udshl_defs.h"
#include "simplectypes.h"
#include "dstring.h"

#include "int_interface_pre.h"
#include "dshow_header.h"

namespace _DSHOWLIB_NAMESPACE
{
    /** Represents an input of a video capture device. **/
    class AnalogChannelItem
    {
        friend udshl::grabber_backend;
    public:
        AnalogChannelItem() : m_ChannelIndex( -1 ), m_PhyType( (PhysicalConnectorType)0xFFFFFF ) {}
        AnalogChannelItem( const AnalogChannelItem& op ) : m_ChannelIndex( op.m_ChannelIndex ), m_PhyType( op.m_PhyType ) {}
        AnalogChannelItem&	operator=( const AnalogChannelItem& op2 ) { m_ChannelIndex = op2.m_ChannelIndex; m_PhyType = op2.m_PhyType; return *this; }

        /** return internal PhysicalConnectorType
         * @return internal PhysicalConnectorType, which is valid only if isValid() returns true
         **/
        PhysicalConnectorType   getPhysicalConnectorType() const { return m_PhyType; };

        /** return index of input
         * @return index of input or -1, which is valid only if isValid() returns true
         **/
        int                     getIndex() const { return m_ChannelIndex; };

        /** test if the input is valid
         * @return true, if the input is valid, else false
         **/
        bool                    isValid() const { return m_ChannelIndex >= 0; }

        /** returns the result of a lexicographical compare of the index
         * @return true, if this is before op
         * @param op the VideoNormItem to compare with
         **/
        bool			operator<( const AnalogChannelItem& op ) const { return m_ChannelIndex < op.m_ChannelIndex; }

        /** test if two channels are equal
         * @param op channel to compare to this
         * @return true if this and op are equal, else false
         **/
        bool			operator==( const AnalogChannelItem& op ) const { return m_ChannelIndex == op.m_ChannelIndex && m_PhyType == op.m_PhyType; }

        /** test if two channels are not equal
         * @param op channel to compare to this
         * @return false if this and op are equal, else true
         **/
        bool			operator!=( const AnalogChannelItem& op ) const { return !operator==( op ); }

        /** test if two items are equal
         * @param op item to compare to this
         * @return true if this and op are equal, else false
         **/
        bool			operator==( const std::string& op ) const { return toString() == op; }
        bool			operator==( const std::wstring& op ) const { return toStringW() == op; }

        /** generates an invalid item
         * @return an invalid item
         * @see isValid()
         **/
        UDSHL_DEPRECATE_FUNCTION_T_( "default constructor" )
        static AnalogChannelItem    createInvalid() { return AnalogChannelItem(); }

        /** Creates a textual representation for this AnalogChannelItem
         * @return The textual representation.
         */
        std::string		toString() const { return wstoas( toString_() ); }
        std::wstring	toStringW() const { return toString_(); }
    private:
        UDSHL_EXP_API_	dstringw	toString_() const;

        /** constructs an AnalogChannelItem */
        AnalogChannelItem( int index, PhysicalConnectorType type ) : m_ChannelIndex( index ), m_PhyType( type ) {}


        /** the PhysicalConnectorType of the wrapped type */
        PhysicalConnectorType   m_PhyType;
        /** the index of this Channel */
        int				        m_ChannelIndex;
    };
}

#endif // !defined(AFX_ANALOGCHANNELITEM_H__31CEA1C4_246E_411C_800F_CF94EE0DBE8D__INCLUDED_)
