
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RefreshPowerOnSlavesEvent : ProcessDevicesEvent
	{
		public RefreshPowerOnSlavesEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
