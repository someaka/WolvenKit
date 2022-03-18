
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCooldownRemovedEvent : gameCooldownSystemEvent
	{
		public gameCooldownRemovedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
