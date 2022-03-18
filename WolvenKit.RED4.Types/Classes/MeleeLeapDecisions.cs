
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeLeapDecisions : MeleeTransition
	{
		public MeleeLeapDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
