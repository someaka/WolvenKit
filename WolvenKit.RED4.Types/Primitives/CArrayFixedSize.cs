namespace WolvenKit.RED4.Types;

public class CArrayFixedSize<T> : CArrayBase<T>, IRedArrayFixedSize<T?> where T : IRedType?
{
    public CArrayFixedSize(int size) : base(size)
    {
        IsReadOnly = true;
    }
}
