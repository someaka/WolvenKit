
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIWatchdogSystem : gameIGameSystem
	{
		public gameIWatchdogSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
