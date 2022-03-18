
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BraindanceFlyEvents : LocomotionBraindanceEvents
	{
		public BraindanceFlyEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
