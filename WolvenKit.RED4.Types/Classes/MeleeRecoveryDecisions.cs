
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeRecoveryDecisions : MeleeTransition
	{
		public MeleeRecoveryDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
