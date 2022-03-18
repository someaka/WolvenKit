
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SellRequest : TransactionRequest
	{
		public SellRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
