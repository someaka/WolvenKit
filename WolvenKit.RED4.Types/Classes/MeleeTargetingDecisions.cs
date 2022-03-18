
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeTargetingDecisions : MeleeTransition
	{
		public MeleeTargetingDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
