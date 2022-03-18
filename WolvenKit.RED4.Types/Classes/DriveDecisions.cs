
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DriveDecisions : VehicleTransition
	{
		public DriveDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
