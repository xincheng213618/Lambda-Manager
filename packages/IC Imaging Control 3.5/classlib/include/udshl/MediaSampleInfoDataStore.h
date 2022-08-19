#pragma once

#include "iframe_def.h"
#include "MediaSampleInfo.h"

namespace _DSHOWLIB_NAMESPACE
{
    struct MediaSampleInfoDataStore
    {
        std::vector<uint8_t>        data;

        bool    update( const IFrame& frame );
        void    update( const std::vector<uint8_t>& frameData );

        /*
         * Finds the chunk with the according id.
         * REturns either the pointer to the specific chunk or NULL
         */

        const uint8_t*             findChunk( int& data_len, uint32_t chunk_id ) const;
        const MediaSampleInfo*     findSampleInfo() const;

        /*
         * Enumerates the chunks present in data.
         * The passed in function object must have the signature of
                bool (* func)( uint32_t chunk_id, const uint8_t* chunk_data, uint32_t chunk_data_len )
         *
         */
        template<class TFunc>
        void    enumChunkItems( TFunc func ) const;

        template<class TStruct>
        const TStruct*  findChunk( uint32_t chunk_id ) const;

        template<class TStruct>
        const TStruct*  findChunk() const;
    };

    template<class TStruct>
    const TStruct*  MediaSampleInfoDataStore::findChunk( uint32_t chunk_id ) const
    {
        int blob_len = 0;
        const uint8_t* ptr = findChunk( blob_len, chunk_id );
        if( ptr == 0 ) {
            return 0;
        }
        if( sizeof( TStruct ) > blob_len ) {
            return 0;
        }

        return reinterpret_cast<const TStruct*>(ptr);
    }
    template<class TStruct>
    const TStruct*  MediaSampleInfoDataStore::findChunk() const
    {
        return findChunk<TStruct>( TStruct::static_chunk_id );
    }

    inline bool     MediaSampleInfoDataStore::update( const IFrame& frame )
    {
        frame.getMediaSampleInfoBlob( data );
        return !data.empty();
    }

    inline void     MediaSampleInfoDataStore::update( const std::vector<uint8_t>& param )
    {
        data = param;
    }

    inline const MediaSampleInfo*     MediaSampleInfoDataStore::findSampleInfo() const
    {
        return findChunk<MediaSampleInfo>();
    }

    namespace detail
    {
        struct chunk_info
        {
            uint32_t chunk_id;
            const uint8_t* chunk_start;
            uint32_t chunk_len;
        };
        UDSHL_EXP_API_ chunk_info      find_chunk_from_sample_info( const uint8_t* ptr_start, const uint8_t* ptr_end, uint32_t chunk_id_to_find );

        template<class TStruct>
        const TStruct*                  find_chunk_from_sample_info( const uint8_t* ptr_start, const uint8_t* ptr_end, uint32_t chunk_id )
        {
            chunk_info info = find_chunk_from_sample_info( ptr_start, ptr_end, chunk_id );
            if( info.chunk_start == NULL ) {
                return NULL;
            }
            if( sizeof( TStruct ) > info.chunk_len ) {
                return NULL;
            }
            return reinterpret_cast<const TStruct*>(info.chunk_start);
        }

        template<class TStruct>
        const TStruct*                  find_chunk_from_sample_info( const uint8_t* ptr_start, const uint8_t* ptr_end )
        {
            return find_chunk_from_sample_info<TStruct>( ptr_start, ptr_end, TStruct::static_chunk_id );
        }

        template<class TFunc>
        inline void                     enum_chunk_items( const uint8_t* ptr_start, const uint8_t* ptr_end, TFunc func )
        {
            const uint8_t* ptr = ptr_start;

            while( (ptr + 8) < ptr_end )
            {
                uint32_t chunk_data_len = *reinterpret_cast<const uint32_t*>(ptr + 0);
                uint32_t chunk_id = *reinterpret_cast<const uint32_t*>(ptr + 4);
                ptr += 8;

                const uint8_t* chunk_data = ptr;

                if( (ptr + chunk_data_len) > ptr_end )
                {
                    return;
                }

                bool should_exit = func( chunk_id, chunk_data, chunk_data_len );
                if( should_exit )
                {
                    return;
                }

                ptr += chunk_data_len;
            }
        }
    }

    inline const uint8_t*       MediaSampleInfoDataStore::findChunk( int& data_len, uint32_t chunk_id ) const
    {
        detail::chunk_info info = detail::find_chunk_from_sample_info( &data[0], &data[0] + data.size(), chunk_id );
        if( info.chunk_id == chunk_id ) {

            data_len = info.chunk_len;
            return info.chunk_start;
        }
        data_len = 0;
        return NULL;
    }

    template<class TFunc>
    inline void                 MediaSampleInfoDataStore::enumChunkItems( TFunc func ) const
    {
        detail::enum_chunk_items( &data[0], &data[0] + data.size(), func );
    }

}


