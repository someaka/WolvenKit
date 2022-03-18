
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataAISubActionSetUnequipSecondaryWeapons_Record : gamedataAISubActionCharacterRecordUnequip_Record
	{
		public gamedataAISubActionSetUnequipSecondaryWeapons_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
