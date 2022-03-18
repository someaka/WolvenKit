
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VaultEvents : LocomotionGroundEvents
	{
		public VaultEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
