
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TakedownSlideToPreyEvents : LocomotionTakedownEvents
	{
		public TakedownSlideToPreyEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
