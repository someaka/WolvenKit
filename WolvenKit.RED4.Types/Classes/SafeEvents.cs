
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SafeEvents : WeaponEventsTransition
	{
		public SafeEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
