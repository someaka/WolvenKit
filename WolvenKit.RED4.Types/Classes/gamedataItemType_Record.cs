
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataItemType_Record : gamedataTweakDBRecord
	{
		public gamedataItemType_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
