
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TakedownLeapToPreyEvents : LocomotionTakedownEvents
	{
		public TakedownLeapToPreyEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
