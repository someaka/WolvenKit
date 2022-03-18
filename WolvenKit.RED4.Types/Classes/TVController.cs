
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TVController : MediaDeviceController
	{
		public TVController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
