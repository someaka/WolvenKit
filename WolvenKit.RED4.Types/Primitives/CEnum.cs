using System;
using System.Diagnostics;
using System.Reflection;

namespace WolvenKit.RED4.Types;

public static class CEnum
{
    public static IRedEnum Parse(Type enumType, string value)
    {
        var method = typeof(CEnum).GetMethod(nameof(Parse), BindingFlags.Public | BindingFlags.Static, null, new[] { typeof(string) }, null);
        if (method == null)
        {
            throw new MissingMethodException("Method CEnum.Parse<T>() could not be found");
        }
        var generic = method.MakeGenericMethod(enumType);

        var result = generic.Invoke(null, new object[] { value });
        if (result == null)
        {
            throw new Exception();
        }

        return (IRedEnum)result;
    }

    public static CEnum<T> Parse<T>(string value) where T : struct, Enum
    {
        if (Enum.TryParse<T>(value, out var result))
        {
            return result;
        }

        return default(T);
    }
}

[DebuggerDisplay("{_value}")]
public readonly struct CEnum<T> : IRedEnum<T>, IEquatable<CEnum<T>> where T : struct, Enum
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly T _value;


    public CEnum()
    {
        _value = default;
    }

    private CEnum(T value)
    {
        _value = value;
    }

    public static implicit operator CEnum<T>(T value) => new(value);
    public static implicit operator T(CEnum<T> value) => value._value;

    public Type GetInnerType() => typeof(T);

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        }

        if (obj.GetType() != this.GetType())
        {
            return false;
        }

        return Equals((CEnum<T>)obj);
    }

    public bool Equals(CEnum<T> other) => Equals(_value, other._value);

    public override int GetHashCode() => _value.GetHashCode();

    public override string ToString() => _value.ToString();
}
