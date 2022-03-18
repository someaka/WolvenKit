
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceUpdateEvent : gameTickableEvent
	{
		public DeviceUpdateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
