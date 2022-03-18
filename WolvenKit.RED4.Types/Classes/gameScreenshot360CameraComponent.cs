
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameScreenshot360CameraComponent : gameCameraComponent
	{
		public gameScreenshot360CameraComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
