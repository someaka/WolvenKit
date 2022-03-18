
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataInventoryItemGroup_Record : gamedataTweakDBRecord
	{
		public gamedataInventoryItemGroup_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
