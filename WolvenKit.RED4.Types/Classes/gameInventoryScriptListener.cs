
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameInventoryScriptListener : gameIInventoryListener
	{
		public gameInventoryScriptListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
