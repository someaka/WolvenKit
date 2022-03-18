
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeChargedHoldDecisions : MeleeTransition
	{
		public MeleeChargedHoldDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
