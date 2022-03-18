
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PickUpBodyAfterTakedownEvents : LocomotionTakedownEvents
	{
		public PickUpBodyAfterTakedownEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
