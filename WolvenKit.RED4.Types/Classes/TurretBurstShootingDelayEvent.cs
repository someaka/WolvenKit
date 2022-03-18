
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TurretBurstShootingDelayEvent : redEvent
	{
		public TurretBurstShootingDelayEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
