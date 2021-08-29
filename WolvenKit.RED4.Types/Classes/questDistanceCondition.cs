using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questDistanceCondition : questTypedCondition
	{
		private CHandle<questIDistanceConditionType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questIDistanceConditionType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
