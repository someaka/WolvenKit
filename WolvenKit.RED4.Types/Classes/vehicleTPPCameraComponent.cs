
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleTPPCameraComponent : gameCameraComponent
	{
		public vehicleTPPCameraComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
