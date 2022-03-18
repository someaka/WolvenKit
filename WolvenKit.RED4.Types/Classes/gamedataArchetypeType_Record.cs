
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataArchetypeType_Record : gamedataTweakDBRecord
	{
		public gamedataArchetypeType_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
