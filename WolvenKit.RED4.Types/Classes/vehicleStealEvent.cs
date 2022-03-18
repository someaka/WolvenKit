
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleStealEvent : redEvent
	{
		public vehicleStealEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
