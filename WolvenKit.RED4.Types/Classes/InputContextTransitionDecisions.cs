
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InputContextTransitionDecisions : DefaultTransition
	{
		public InputContextTransitionDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
