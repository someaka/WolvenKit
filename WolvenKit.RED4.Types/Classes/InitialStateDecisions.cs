
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InitialStateDecisions : InputContextTransitionDecisions
	{
		public InitialStateDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
