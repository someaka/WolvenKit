
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ConsumableStartupDecisions : ConsumableTransitions
	{
		public ConsumableStartupDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
