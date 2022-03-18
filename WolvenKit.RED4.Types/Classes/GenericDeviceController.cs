
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GenericDeviceController : ScriptableDeviceComponent
	{
		public GenericDeviceController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
