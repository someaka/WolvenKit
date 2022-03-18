
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleDetachAllPartsEvent : redEvent
	{
		public vehicleDetachAllPartsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
