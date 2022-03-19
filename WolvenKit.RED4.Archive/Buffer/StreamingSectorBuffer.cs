using System.Collections.Generic;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer;

public class StreamingSectorBuffer : IParseableBuffer
{
    public IRedType Data => null;

    public Dictionary<int, List<StreamingSectorTransform>> Transforms = new();

    public StreamingSectorBuffer()
    {

    }
}