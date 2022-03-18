
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleQuestRestrictedContextEvents : VehicleNoDriveContextEvents
	{
		public VehicleQuestRestrictedContextEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
