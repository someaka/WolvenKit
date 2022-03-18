
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EffectExecutor_SetDeviceON : EffectExecutor_Device
	{
		public EffectExecutor_SetDeviceON()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
