
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleToggleQuestWeaponEnabledEvent : redEvent
	{
		public vehicleToggleQuestWeaponEnabledEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
