using System;
using System.Diagnostics;

namespace WolvenKit.RED4.Types;

public class BaseStringType : IRedPrimitive<string>, IEquatable<BaseStringType>, IComparable<BaseStringType>, IComparable
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    protected readonly string? _value;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public int Length => _value!.Length;

    internal BaseStringType() { }
    protected BaseStringType(string value)
    {
        _value = value;
    }

    public static implicit operator BaseStringType(string value) => new(value);
    public static implicit operator string?(BaseStringType value) => value._value;

    public int CompareTo(object? value)
    {
        if (value == null)
        {
            return 1;
        }

        if (!(value is BaseStringType other))
        {
            throw new ArgumentException();
        }

        if (_value == null)
        {
            return -1;
        }

        return _value.CompareTo(other);
    }

    public int CompareTo(BaseStringType? other) => string.CompareOrdinal(_value, other?._value);
    public bool Equals(BaseStringType? other) => string.Equals(_value, other?._value);

    public static bool Equals(BaseStringType? a, BaseStringType? b)
    {
        if (ReferenceEquals(a, b))
        {
            return true;
        }

        if (a is null || b is null || a.Length != b.Length)
        {
            return false;
        }

        return string.Equals(a, b._value);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        }

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj.GetType() != this.GetType())
        {
            return false;
        }

        return Equals((BaseStringType)obj);
    }

    public override int GetHashCode() => _value != null ? _value.GetHashCode() : 0;
}
