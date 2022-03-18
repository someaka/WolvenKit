
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerWeaponSetupEvent : redEvent
	{
		public PlayerWeaponSetupEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
