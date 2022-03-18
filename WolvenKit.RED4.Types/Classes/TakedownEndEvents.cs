
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TakedownEndEvents : LocomotionTakedownEvents
	{
		public TakedownEndEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
