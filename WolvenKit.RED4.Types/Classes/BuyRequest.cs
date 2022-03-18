
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BuyRequest : TransactionRequest
	{
		public BuyRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
