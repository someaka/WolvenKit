
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UpdateWeaponStatsEvent : redEvent
	{
		public UpdateWeaponStatsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
