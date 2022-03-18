
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FullAutoEvents : WeaponEventsTransition
	{
		public FullAutoEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
