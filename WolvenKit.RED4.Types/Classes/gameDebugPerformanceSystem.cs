
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDebugPerformanceSystem : gameIGameSystem
	{
		public gameDebugPerformanceSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
