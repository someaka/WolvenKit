
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PickupBodyWorkspotDelayEvent : redEvent
	{
		public PickupBodyWorkspotDelayEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
