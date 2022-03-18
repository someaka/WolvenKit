
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AttachVendorRequest : MarketSystemRequest
	{
		public AttachVendorRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
