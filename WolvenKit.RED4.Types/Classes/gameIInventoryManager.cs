
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIInventoryManager : gameIGameSystem
	{
		public gameIInventoryManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
