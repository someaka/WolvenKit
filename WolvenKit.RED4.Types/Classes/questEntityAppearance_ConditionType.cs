using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questEntityAppearance_ConditionType : questIEntityConditionType
	{
		private gameEntityReference _entityRef;
		private CName _appearance;

		[Ordinal(0)] 
		[RED("entityRef")] 
		public gameEntityReference EntityRef
		{
			get => GetProperty(ref _entityRef);
			set => SetProperty(ref _entityRef, value);
		}

		[Ordinal(1)] 
		[RED("appearance")] 
		public CName Appearance
		{
			get => GetProperty(ref _appearance);
			set => SetProperty(ref _appearance, value);
		}
	}
}
