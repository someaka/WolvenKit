
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataCharacterEntry_Record : gamedataTweakDBRecord
	{
		public gamedataCharacterEntry_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
