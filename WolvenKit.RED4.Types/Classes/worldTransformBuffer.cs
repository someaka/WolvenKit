namespace WolvenKit.RED4.Types;

public partial class worldTransformBuffer : RedBaseClass
{
	[Ordinal(0)] 
	[RED("sharedDataBuffer")] 
	public CHandle<worldSharedDataBuffer> SharedDataBuffer
	{
		get => GetPropertyValue<CHandle<worldSharedDataBuffer>>();
		set => SetPropertyValue<CHandle<worldSharedDataBuffer>>(value);
	}

	[Ordinal(1)] 
	[RED("startIndex")] 
	public CUInt32 StartIndex
	{
		get => GetPropertyValue<CUInt32>();
		set => SetPropertyValue<CUInt32>(value);
	}

	[Ordinal(2)] 
	[RED("numElements")] 
	public CUInt32 NumElements
	{
		get => GetPropertyValue<CUInt32>();
		set => SetPropertyValue<CUInt32>(value);
	}

	public worldTransformBuffer()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
