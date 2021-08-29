using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeaponRadialSlot : RadialSlot
	{
		private CEnum<gamedataEquipmentArea> _equipmentArea;
		private CInt32 _index;

		[Ordinal(9)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetProperty(ref _equipmentArea);
			set => SetProperty(ref _equipmentArea, value);
		}

		[Ordinal(10)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}
	}
}
