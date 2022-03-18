
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DelayedUpdateDeviceStateEvent : redEvent
	{
		public DelayedUpdateDeviceStateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
