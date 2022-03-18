
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleNoDriveContextEvents : InputContextTransitionEvents
	{
		public VehicleNoDriveContextEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
