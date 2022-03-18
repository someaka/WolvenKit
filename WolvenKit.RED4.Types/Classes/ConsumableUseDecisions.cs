
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ConsumableUseDecisions : ConsumableTransitions
	{
		public ConsumableUseDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
