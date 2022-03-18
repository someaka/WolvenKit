
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OverheatEvents : WeaponEventsTransition
	{
		public OverheatEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
