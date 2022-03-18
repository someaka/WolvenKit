
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIStoppedBeingTrackedAsHostile : AIAIEvent
	{
		public AIStoppedBeingTrackedAsHostile()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
