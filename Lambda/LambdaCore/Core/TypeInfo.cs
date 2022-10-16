using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LambdaManager.Conversion;
using LambdaManager.DataType;

namespace LambdaManager.Core
{
    public delegate object? Converter(object value);
    public enum ArgumentType
    {
        NO_ARGS,
        JSON_STRING,
        JSON_OBJECT,
        STL_MAP,
        POINTER,
        POINTER2,
        POINTER4
    }
    public enum HandlerType
    {
        MESSAGE1,
        MESSAGE2,
        GET_ARRAY_SIZE,
        IMAGE_INIT,
        IMAGE_UPDATE,
        START_SERVICE,
        STOP_SERVICE,
        SCHEDULER,
        HANDLER_RAISE,
        CLOSE_IMAGE_VIEW
    }

    public class TypeInfo
    {
        private static int[] nonJsonTypes = new int[11]
        {
        13, 14, 17, 18, 20, 21, 22, 80, 81, 82,
        83
        };

        public int Id { get; set; }

        public int Size { get; set; }

        public Converter? GetConverter(List<CastType> castTypes)
        {
            if (castTypes.Count == 0)
            {
                return null;
            }
            if (castTypes[0] == CastType.NO_CAST)
            {
                return null;
            }
            Converter converter = castTypes[0] switch
            {
                CastType.CAST_ADDRESS => GetAddress,
                CastType.CAST_VALUE => GetValue,
                CastType.CAST_BOOL => GetBoolValue,
                CastType.CAST_BOOLEAN => GetBooleanValue,
                CastType.CAST_BYTE => GetByteValue,
                CastType.CAST_SBYTE => GetSByteValue,
                CastType.CAST_CHAR => GetCharValue,
                CastType.CAST_UCHAR => GetUCharValue,
                CastType.CAST_INT16 => GetInt16Value,
                CastType.CAST_UINT16 => GetUInt16Value,
                CastType.CAST_INT32 => GetInt32Value,
                CastType.CAST_UINT32 => GetUInt32Value,
                CastType.CAST_DATETIME => GetDateTimeValue,
                CastType.CAST_INT64 => GetInt64Value,
                CastType.CAST_UINT64 => GetUInt64Value,
                CastType.CAST_FLOAT => GetFloatValue,
                CastType.CAST_DOUBLE => GetDoubleValue,
                CastType.CAST_DECIMAL => GetDecimalValue,
                _ => null,
            };

            if (converter == null || castTypes.Count == 1)
            {
                return converter;
            }
            if (castTypes[1] == CastType.CAST_VALUE)
            {
                converter = (Converter)Delegate.Combine(new Converter(GetValue), converter);
            }
            else if (castTypes[1] == CastType.CAST_ADDRESS)
            {
                return (Converter)Delegate.Combine(converter, new Converter(GetAddress));
            }
            if (castTypes.Count == 3 && castTypes[2] == CastType.CAST_ADDRESS)
            {
                converter = (Converter)Delegate.Combine(converter, new Converter(GetAddress));
            }
            return converter;
        }

        public object? GetAddress(object value)
        {
            return T0.ToAddress(this, value);
        }

        public object? GetValue(object address)
        {
            return T0.ToValue(this, address);
        }

        public object? GetBooleanValue(object value)
        {
            return T11.ToBoolean(this, value);
        }

        public object? GetBoolValue(object value)
        {
            return T12.ToBool(this, value);
        }

        public object? GetByteValue(object value)
        {
            return T14.ToByte(this, value);
        }

        public object? GetSByteValue(object value)
        {
            return T18.ToSByte(this, value);
        }

        public object? GetCharValue(object value)
        {
            return T21.ToChar(this, value);
        }

        public object? GetUCharValue(object value)
        {
            return T22.ToUChar(this, value);
        }

        public object? GetInt16Value(object value)
        {
            return T24.ToInt16(this, value);
        }

        public object? GetUInt16Value(object value)
        {
            return T28.ToUInt16(this, value);
        }

        public object? GetInt32Value(object value)
        {
            return T31.ToInt32(this, value);
        }

        public object? GetUInt32Value(object value)
        {
            return T36.ToUInt32(this, value);
        }

        public object? GetDateTimeValue(object value)
        {
            return T31.ToInt32(this, value);
        }

        public object? GetInt64Value(object value)
        {
            return T41.ToInt64(this, value);
        }

        public object? GetUInt64Value(object value)
        {
            return T45.ToUInt64(this, value);
        }

        public object? GetFloatValue(object value)
        {
            return T51.ToFloat(this, value);
        }

        public object? GetDoubleValue(object value)
        {
            return T56.ToDouble(this, value);
        }

        public object? GetDecimalValue(object value)
        {
            return T66.ToDecimal(this, value);
        }

        public bool IsJsonType()
        {
            return Array.IndexOf(nonJsonTypes, Id) == -1;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Size: {Size}";
        }
    }

}

