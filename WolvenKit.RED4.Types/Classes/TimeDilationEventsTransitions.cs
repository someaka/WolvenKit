
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TimeDilationEventsTransitions : TimeDilationTransitions
	{
		public TimeDilationEventsTransitions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
