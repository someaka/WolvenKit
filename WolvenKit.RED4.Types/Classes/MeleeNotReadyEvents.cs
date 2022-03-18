
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeNotReadyEvents : MeleeEventsTransition
	{
		public MeleeNotReadyEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
