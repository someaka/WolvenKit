
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ConveyorController : ScriptableDeviceComponent
	{
		public ConveyorController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
