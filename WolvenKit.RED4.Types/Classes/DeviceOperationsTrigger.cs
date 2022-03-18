
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceOperationsTrigger : IScriptable
	{
		public DeviceOperationsTrigger()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
