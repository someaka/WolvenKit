
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AITargetTrackerManager : AITargetTrackerManagerInterface
	{
		public AITargetTrackerManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
