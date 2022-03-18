
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleLightSetupEvent : redEvent
	{
		public VehicleLightSetupEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
