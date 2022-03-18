
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerHasTakedownWeaponEquippedPrereq : gameIScriptablePrereq
	{
		public PlayerHasTakedownWeaponEquippedPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
