
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleDumpBodyCloseTrunkEvent : redEvent
	{
		public VehicleDumpBodyCloseTrunkEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
