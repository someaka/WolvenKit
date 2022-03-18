
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BarbedWireController : ActivatedDeviceController
	{
		public BarbedWireController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
