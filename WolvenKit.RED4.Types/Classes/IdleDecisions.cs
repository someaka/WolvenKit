
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IdleDecisions : VehicleTransition
	{
		public IdleDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
