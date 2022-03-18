
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LadderEnterContextEvents : InputContextTransitionEvents
	{
		public LadderEnterContextEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
