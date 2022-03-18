
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataMinigame_Def_Record : gamedataTweakDBRecord
	{
		public gamedataMinigame_Def_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
