
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeHoldEvents : MeleeEventsTransition
	{
		public MeleeHoldEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
