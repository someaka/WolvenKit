
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InactiveCoverDecisions : CoverActionTransition
	{
		public InactiveCoverDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
