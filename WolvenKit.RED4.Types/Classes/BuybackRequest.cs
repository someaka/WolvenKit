
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BuybackRequest : TransactionRequest
	{
		public BuybackRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
