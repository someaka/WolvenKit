
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CrouchEvents : LocomotionGroundEvents
	{
		public CrouchEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
