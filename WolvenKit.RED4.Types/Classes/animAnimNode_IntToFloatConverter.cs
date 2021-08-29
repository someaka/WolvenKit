using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_IntToFloatConverter : animAnimNode_FloatValue
	{
		private animIntLink _inputNode;

		[Ordinal(11)] 
		[RED("inputNode")] 
		public animIntLink InputNode
		{
			get => GetProperty(ref _inputNode);
			set => SetProperty(ref _inputNode, value);
		}
	}
}
