
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TakedownUnmountPreyEvents : LocomotionTakedownEvents
	{
		public TakedownUnmountPreyEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
