
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LocomotionSwimming : LocomotionTransition
	{
		public LocomotionSwimming()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
