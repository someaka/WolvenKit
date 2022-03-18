
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataArchetypeData_Record : gamedataTweakDBRecord
	{
		public gamedataArchetypeData_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
