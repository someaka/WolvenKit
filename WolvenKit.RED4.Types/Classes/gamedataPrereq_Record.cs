
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataPrereq_Record : gamedataTweakDBRecord
	{
		public gamedataPrereq_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
