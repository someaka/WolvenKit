
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AITargetTrackerManagerInterface : gameIGameSystem
	{
		public AITargetTrackerManagerInterface()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
