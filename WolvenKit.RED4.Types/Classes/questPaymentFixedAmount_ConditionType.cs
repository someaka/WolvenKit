
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPaymentFixedAmount_ConditionType : questIPayment_ConditionType
	{
		public questPaymentFixedAmount_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
