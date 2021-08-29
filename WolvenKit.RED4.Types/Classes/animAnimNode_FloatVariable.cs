using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_FloatVariable : animAnimNode_FloatValue
	{
		private CName _variableName;

		[Ordinal(11)] 
		[RED("variableName")] 
		public CName VariableName
		{
			get => GetProperty(ref _variableName);
			set => SetProperty(ref _variableName, value);
		}
	}
}
