
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerVehicleStatePrereq : gameIScriptablePrereq
	{
		public PlayerVehicleStatePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
