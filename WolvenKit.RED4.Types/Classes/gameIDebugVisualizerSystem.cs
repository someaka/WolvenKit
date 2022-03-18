
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIDebugVisualizerSystem : gameIGameSystem
	{
		public gameIDebugVisualizerSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
