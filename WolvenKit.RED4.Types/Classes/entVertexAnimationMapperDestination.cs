using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entVertexAnimationMapperDestination : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("vertexCustomSlotIndex")] 
		public CUInt32 VertexCustomSlotIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}
	}
}
