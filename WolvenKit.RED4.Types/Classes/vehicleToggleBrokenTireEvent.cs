
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleToggleBrokenTireEvent : redEvent
	{
		public vehicleToggleBrokenTireEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
