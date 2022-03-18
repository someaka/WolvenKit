
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeIdleEvents : MeleeEventsTransition
	{
		public MeleeIdleEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
