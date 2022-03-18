
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeParriedEvents : MeleeEventsTransition
	{
		public MeleeParriedEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
