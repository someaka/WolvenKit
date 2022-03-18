
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TakedownReleasePreyEvents : LocomotionTakedownEvents
	{
		public TakedownReleasePreyEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
