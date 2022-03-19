using System.Diagnostics;

namespace WolvenKit.RED4.Types;

[RED("String")]
[REDType(IsValueType = true)]
[DebuggerDisplay("{_value}", Type = "CString")]
public sealed class CString : BaseStringType
{
    public CString() { }
    private CString(string value) : base(value) { }

    public static implicit operator CString(string value) => new(value);
    public static implicit operator string?(CString value) => value._value ?? null;

    public static bool operator ==(CString a, CString b) => BaseStringType.Equals(a, b);
    public static bool operator !=(CString a, CString b) => !(a == b);

    public override string? ToString() => this;

    private bool Equals(CString other) => base.Equals(other);

    public override bool Equals(object? obj) => ReferenceEquals(this, obj) || (obj is CString other && Equals(other));

    public override int GetHashCode() => base.GetHashCode();
}
