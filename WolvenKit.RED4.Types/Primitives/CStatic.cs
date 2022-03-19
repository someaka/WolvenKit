namespace WolvenKit.RED4.Types;

[RED("static")]
public class CStatic<T> : CArrayBase<T>, IRedStatic<T?> where T : IRedType
{
    public CStatic() { }
    public CStatic(int size) : base(size) { }
}
