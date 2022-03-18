
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AimingContextEvents : InputContextTransitionEvents
	{
		public AimingContextEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
