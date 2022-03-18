
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UiContextDecisions : InputContextTransitionDecisions
	{
		public UiContextDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
