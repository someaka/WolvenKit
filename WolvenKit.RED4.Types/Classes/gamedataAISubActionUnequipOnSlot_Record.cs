
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataAISubActionUnequipOnSlot_Record : gamedataAISubActionCharacterRecordUnequip_Record
	{
		public gamedataAISubActionUnequipOnSlot_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
