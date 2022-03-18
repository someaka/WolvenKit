
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExplosiveTriggerDeviceController : ExplosiveDeviceController
	{
		public ExplosiveTriggerDeviceController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
