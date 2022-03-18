
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SemiAutoEvents : WeaponEventsTransition
	{
		public SemiAutoEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
