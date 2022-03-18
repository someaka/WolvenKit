
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TakedownExecuteTakedownEvents : LocomotionTakedownEvents
	{
		public TakedownExecuteTakedownEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
