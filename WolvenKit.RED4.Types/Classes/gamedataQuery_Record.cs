
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataQuery_Record : gamedataTweakDBRecord
	{
		public gamedataQuery_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
