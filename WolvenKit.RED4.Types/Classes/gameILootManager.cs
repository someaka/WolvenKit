
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameILootManager : gameIGameSystem
	{
		public gameILootManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
