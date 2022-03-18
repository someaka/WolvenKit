
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeSafeDecisions : MeleeTransition
	{
		public MeleeSafeDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
