
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCNotMountedToVehiclePrereq : gameIScriptablePrereq
	{
		public NPCNotMountedToVehiclePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
