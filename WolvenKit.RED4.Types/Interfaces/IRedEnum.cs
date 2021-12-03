using System;

namespace WolvenKit.RED4.Types
{
    public interface IRedBitField : IRedType
    {
        public string ToBitFieldString();
    }

    public interface IRedBitField<T> : IRedBitField, IRedPrimitive<T>, IRedGenericType<T> where T : struct, Enum
    {
    }

    public interface IRedEnum : IRedType
    {
        public string ToEnumString();

        public Type GetInnerType();

        public void SetValue(string str);
    }

    public interface IRedEnum<T> : IRedEnum, IRedPrimitive<T>, IRedGenericType<T> where T : struct, Enum
    {
    }
}