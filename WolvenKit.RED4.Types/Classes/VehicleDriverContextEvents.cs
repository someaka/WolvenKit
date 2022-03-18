
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleDriverContextEvents : InputContextTransitionEvents
	{
		public VehicleDriverContextEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
