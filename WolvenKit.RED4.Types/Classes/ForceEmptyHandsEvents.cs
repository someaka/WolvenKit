
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForceEmptyHandsEvents : UpperBodyEventsTransition
	{
		public ForceEmptyHandsEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
