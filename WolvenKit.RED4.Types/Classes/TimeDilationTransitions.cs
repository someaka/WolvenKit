
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TimeDilationTransitions : DefaultTransition
	{
		public TimeDilationTransitions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
