
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameStackedItemData : gameItemData
	{
		public gameStackedItemData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
