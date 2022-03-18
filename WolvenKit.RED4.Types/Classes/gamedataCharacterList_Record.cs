
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataCharacterList_Record : gamedataTweakDBRecord
	{
		public gamedataCharacterList_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
