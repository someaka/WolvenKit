
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameContainerInventoryListener : gameIInventoryListener
	{
		public gameContainerInventoryListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
