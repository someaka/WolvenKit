
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDebugCheatsSystem : gameIDebugCheatsSystem
	{
		public gameDebugCheatsSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
