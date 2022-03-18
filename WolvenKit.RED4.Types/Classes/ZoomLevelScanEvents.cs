
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ZoomLevelScanEvents : ZoomEventsTransition
	{
		public ZoomLevelScanEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
