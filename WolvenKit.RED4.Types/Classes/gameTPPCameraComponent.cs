
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTPPCameraComponent : gameCameraComponent
	{
		public gameTPPCameraComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
