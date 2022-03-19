using System;
using System.Diagnostics;
using System.Reflection;

namespace WolvenKit.RED4.Types;

public static class CBitField
{
    public static IRedBitField Parse(Type enumType, string value)
    {
        var method = typeof(CBitField).GetMethod(nameof(Parse), BindingFlags.Public | BindingFlags.Static, null, new[] { typeof(string) }, null);
        if (method == null)
        {
            throw new MissingMethodException("Method CBitfield.Parse<T>() could not be found");
        }
        var generic = method.MakeGenericMethod(enumType);

        var result = generic.Invoke(null, new object[] { value });
        if (result == null)
        {
            throw new Exception();
        }

        return (IRedBitField)result;
    }

    public static CBitField<T> Parse<T>(string value) where T : struct, Enum
    {
        if (Enum.TryParse<T>(value, out var result))
        {
            return result;
        }

        return default(T);
    }
}

[DebuggerDisplay("{_value}")]
public readonly struct CBitField<T> : IRedBitField<T>, IEquatable<CBitField<T>> where T : struct, Enum
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly T _value;


    public CBitField()
    {
        _value = default;
    }

    private CBitField(T value)
    {
        _value = value;
    }

    public static implicit operator CBitField<T>(T value) => new(value);
    public static implicit operator T(CBitField<T> value) => value._value;

    public static implicit operator CBitField<T>(Enum value) => new((T)value);
    public static implicit operator Enum(CBitField<T> value) => value._value;

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

        return Equals((CBitField<T>)obj);
    }

    public bool Equals(CBitField<T> other)
    {
        return Equals(_value, other._value);
    }

    public override int GetHashCode() => _value.GetHashCode();

    public override string ToString() => _value.ToString();
}
