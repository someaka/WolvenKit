
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questObjectInventoryListener : gameIInventoryListener
	{
		public questObjectInventoryListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
