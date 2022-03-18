
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleReadyToParkEvent : redEvent
	{
		public vehicleReadyToParkEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
