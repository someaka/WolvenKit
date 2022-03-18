
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TurretShootingIntervalEvent : redEvent
	{
		public TurretShootingIntervalEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
