
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeDashEvents : MeleeEventsTransition
	{
		public MeleeDashEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
