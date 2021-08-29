using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AttributeUpgradePurchased : redEvent
	{
		private CEnum<PerkMenuAttribute> _attributeType;
		private CHandle<AttributeData> _attributeData;

		[Ordinal(0)] 
		[RED("attributeType")] 
		public CEnum<PerkMenuAttribute> AttributeType
		{
			get => GetProperty(ref _attributeType);
			set => SetProperty(ref _attributeType, value);
		}

		[Ordinal(1)] 
		[RED("attributeData")] 
		public CHandle<AttributeData> AttributeData
		{
			get => GetProperty(ref _attributeData);
			set => SetProperty(ref _attributeData, value);
		}
	}
}
