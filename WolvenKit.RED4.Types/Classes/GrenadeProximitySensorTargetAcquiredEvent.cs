
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GrenadeProximitySensorTargetAcquiredEvent : redEvent
	{
		public GrenadeProximitySensorTargetAcquiredEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
