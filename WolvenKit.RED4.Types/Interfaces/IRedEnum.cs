using System;

namespace WolvenKit.RED4.Types;

public interface IRedBitField : IRedType
{
    public Type GetInnerType();
    public string ToString();
}

public interface IRedBitField<T> : IRedBitField, IRedPrimitive<T>, IRedGenericType<T> where T : struct, Enum
{
}

public interface IRedEnum : IRedType
{
    public Type GetInnerType();
    public string ToString();
}

public interface IRedEnum<T> : IRedEnum, IRedPrimitive<T>, IRedGenericType<T> where T : struct, Enum
{
}