
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleRepairEvent : redEvent
	{
		public vehicleRepairEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
