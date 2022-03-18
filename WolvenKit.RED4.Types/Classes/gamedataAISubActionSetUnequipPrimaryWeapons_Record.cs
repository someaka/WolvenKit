
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataAISubActionSetUnequipPrimaryWeapons_Record : gamedataAISubActionCharacterRecordUnequip_Record
	{
		public gamedataAISubActionSetUnequipPrimaryWeapons_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
