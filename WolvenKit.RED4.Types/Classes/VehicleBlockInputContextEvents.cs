
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleBlockInputContextEvents : InputContextTransitionEvents
	{
		public VehicleBlockInputContextEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
