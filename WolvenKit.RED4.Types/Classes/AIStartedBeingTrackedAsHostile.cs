
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIStartedBeingTrackedAsHostile : AIAIEvent
	{
		public AIStartedBeingTrackedAsHostile()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
