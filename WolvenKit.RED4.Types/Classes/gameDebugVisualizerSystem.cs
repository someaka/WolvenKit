
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDebugVisualizerSystem : gameIDebugVisualizerSystem
	{
		public gameDebugVisualizerSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
