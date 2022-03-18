
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StashControllerPS : ScriptableDeviceComponentPS
	{
		public StashControllerPS()
		{
			ShouldScannerShowStatus = false;
			ShouldScannerShowNetwork = false;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
