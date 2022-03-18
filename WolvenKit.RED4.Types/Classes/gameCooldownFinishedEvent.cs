
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCooldownFinishedEvent : gameCooldownSystemEvent
	{
		public gameCooldownFinishedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
