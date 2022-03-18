
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDeviceCameraControlComponent : gameComponent
	{
		public gameDeviceCameraControlComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
