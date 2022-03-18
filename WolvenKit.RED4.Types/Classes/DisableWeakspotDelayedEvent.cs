
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisableWeakspotDelayedEvent : DelayEvent
	{
		public DisableWeakspotDelayedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
