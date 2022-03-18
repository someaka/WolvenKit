
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleTeleportEvent : redEvent
	{
		public vehicleTeleportEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
