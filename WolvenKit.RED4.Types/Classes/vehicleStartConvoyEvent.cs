
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleStartConvoyEvent : redEvent
	{
		public vehicleStartConvoyEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
