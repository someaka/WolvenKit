
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OnReleaseWorkspotEvent : OnWorkspotAvailabilityEvent
	{
		public OnReleaseWorkspotEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
