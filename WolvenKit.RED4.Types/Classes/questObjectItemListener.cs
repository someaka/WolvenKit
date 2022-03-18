
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questObjectItemListener : gameIInventoryListener
	{
		public questObjectItemListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
