
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExitingDecisions : VehicleTransition
	{
		public ExitingDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
