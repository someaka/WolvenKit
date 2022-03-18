
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataSquadBase_Record : gamedataTweakDBRecord
	{
		public gamedataSquadBase_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
