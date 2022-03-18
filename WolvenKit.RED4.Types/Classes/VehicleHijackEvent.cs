
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleHijackEvent : redEvent
	{
		public VehicleHijackEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
