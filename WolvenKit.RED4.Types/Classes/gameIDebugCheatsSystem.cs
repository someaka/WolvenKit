
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIDebugCheatsSystem : gameIReplicatedGameSystem
	{
		public gameIDebugCheatsSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
