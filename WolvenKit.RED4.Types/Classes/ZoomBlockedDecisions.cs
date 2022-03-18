
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ZoomBlockedDecisions : ZoomDecisionsTransition
	{
		public ZoomBlockedDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
