
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeHoldDecisions : MeleeTransition
	{
		public MeleeHoldDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
