
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EmptyHandsEvents : UpperBodyEventsTransition
	{
		public EmptyHandsEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
