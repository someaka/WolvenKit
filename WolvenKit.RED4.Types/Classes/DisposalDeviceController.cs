
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisposalDeviceController : ScriptableDeviceComponent
	{
		public DisposalDeviceController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
