
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataNPCEquipmentItem_Record : gamedataNPCEquipmentGroupEntry_Record
	{
		public gamedataNPCEquipmentItem_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
