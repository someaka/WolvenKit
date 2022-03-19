using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer;

public class WorldTransformsBuffer : IParseableBuffer
{
    public IRedType Data => Transforms;

    public CArray<WorldTransform> Transforms = new();

    public WorldTransformsBuffer()
    {

    }
}

public class WorldTransformExt : WorldTransform
{
    public Vector3 Scale = new();

    public WorldTransformExt() : base()
    {

    }
}