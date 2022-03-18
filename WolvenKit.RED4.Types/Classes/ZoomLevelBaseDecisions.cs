
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ZoomLevelBaseDecisions : ZoomDecisionsTransition
	{
		public ZoomLevelBaseDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
