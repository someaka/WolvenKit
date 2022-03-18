
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIJoinTrafficEvent : AIAIEvent
	{
		public AIJoinTrafficEvent()
		{
			Name = "runAwayOnTraffic";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
