
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InactiveCoverEvents : CoverActionEventsTransition
	{
		public InactiveCoverEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
