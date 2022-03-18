
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleBodyDisposalPerformedEvent : redEvent
	{
		public VehicleBodyDisposalPerformedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
