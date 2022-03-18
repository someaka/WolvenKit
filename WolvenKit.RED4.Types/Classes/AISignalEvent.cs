
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISignalEvent : AITaggedAIEvent
	{
		public AISignalEvent()
		{
			Name = "Behavior.Signal";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
