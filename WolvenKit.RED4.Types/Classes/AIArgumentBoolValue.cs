using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIArgumentBoolValue : AIArgumentDefinition
	{
		private CEnum<AIArgumentType> _type;
		private CBool _defaultValue;

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<AIArgumentType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(4)] 
		[RED("defaultValue")] 
		public CBool DefaultValue
		{
			get => GetProperty(ref _defaultValue);
			set => SetProperty(ref _defaultValue, value);
		}
	}
}
