
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RadioController : MediaDeviceController
	{
		public RadioController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
