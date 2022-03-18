
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetVehicleHijackEvent : redEvent
	{
		public ResetVehicleHijackEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
