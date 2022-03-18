
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeIdleDecisions : MeleeTransition
	{
		public MeleeIdleDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
