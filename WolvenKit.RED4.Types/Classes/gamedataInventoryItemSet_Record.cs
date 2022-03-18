
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataInventoryItemSet_Record : gamedataTweakDBRecord
	{
		public gamedataInventoryItemSet_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
