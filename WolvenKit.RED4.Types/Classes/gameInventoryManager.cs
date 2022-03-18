
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameInventoryManager : gameIInventoryManager
	{
		public gameInventoryManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
