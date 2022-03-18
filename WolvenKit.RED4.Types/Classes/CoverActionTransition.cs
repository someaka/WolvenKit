
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CoverActionTransition : LocomotionTransition
	{
		public CoverActionTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
