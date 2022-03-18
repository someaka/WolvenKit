
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActivatorOperationTriggerData : DeviceOperationTriggerData
	{
		public ActivatorOperationTriggerData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
