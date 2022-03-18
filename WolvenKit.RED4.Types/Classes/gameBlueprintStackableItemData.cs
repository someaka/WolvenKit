
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameBlueprintStackableItemData : gameItemData
	{
		public gameBlueprintStackableItemData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
