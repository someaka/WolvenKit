
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisableAllVehicleInteractionsNotEnabledPrereq : gameIScriptablePrereq
	{
		public DisableAllVehicleInteractionsNotEnabledPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
