
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeEventsTransition : MeleeTransition
	{
		public MeleeEventsTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
