
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CancelDeviceUpdateEvent : redEvent
	{
		public CancelDeviceUpdateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
