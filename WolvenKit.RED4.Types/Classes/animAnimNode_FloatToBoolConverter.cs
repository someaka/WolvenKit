using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_FloatToBoolConverter : animAnimNode_BoolValue
	{
		private animFloatLink _inputNode;

		[Ordinal(11)] 
		[RED("inputNode")] 
		public animFloatLink InputNode
		{
			get => GetProperty(ref _inputNode);
			set => SetProperty(ref _inputNode, value);
		}
	}
}
