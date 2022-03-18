
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeTargetingEvents : MeleeEventsTransition
	{
		public MeleeTargetingEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
