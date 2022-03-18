
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TakedownBeginEvents : LocomotionTakedownEvents
	{
		public TakedownBeginEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
