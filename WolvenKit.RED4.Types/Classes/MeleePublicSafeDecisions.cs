
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleePublicSafeDecisions : MeleeTransition
	{
		public MeleePublicSafeDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
