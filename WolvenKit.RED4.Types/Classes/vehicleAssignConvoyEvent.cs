
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleAssignConvoyEvent : redEvent
	{
		public vehicleAssignConvoyEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
