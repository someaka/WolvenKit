
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiItemDataSourceListener : gameIInventoryListener
	{
		public gameuiItemDataSourceListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
