
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeaponStateMachinePrereq : gameIScriptablePrereq
	{
		public WeaponStateMachinePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
