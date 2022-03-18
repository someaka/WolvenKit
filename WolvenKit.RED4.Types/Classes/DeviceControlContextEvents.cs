
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceControlContextEvents : InputContextTransitionEvents
	{
		public DeviceControlContextEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
