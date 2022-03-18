
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataNPCEquipmentItemPool_Record : gamedataNPCEquipmentGroupEntry_Record
	{
		public gamedataNPCEquipmentItemPool_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
