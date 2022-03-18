
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataInventoryItem_Record : gamedataTweakDBRecord
	{
		public gamedataInventoryItem_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
