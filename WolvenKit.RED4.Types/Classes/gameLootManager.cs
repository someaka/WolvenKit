
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameLootManager : gameILootManager
	{
		public gameLootManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
