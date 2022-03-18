
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ZoomLevelBaseEvents : ZoomEventsTransition
	{
		public ZoomLevelBaseEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
