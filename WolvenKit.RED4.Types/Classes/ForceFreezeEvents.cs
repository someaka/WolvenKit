
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForceFreezeEvents : LocomotionGroundEvents
	{
		public ForceFreezeEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
