
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceSystemBase : InteractiveMasterDevice
	{
		public DeviceSystemBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
