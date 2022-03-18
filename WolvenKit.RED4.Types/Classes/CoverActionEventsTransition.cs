
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CoverActionEventsTransition : CoverActionTransition
	{
		public CoverActionEventsTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
