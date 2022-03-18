
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameLootBagInventoryListener : gameIInventoryListener
	{
		public gameLootBagInventoryListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
