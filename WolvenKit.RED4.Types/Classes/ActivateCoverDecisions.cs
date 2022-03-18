
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActivateCoverDecisions : CoverActionTransition
	{
		public ActivateCoverDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
