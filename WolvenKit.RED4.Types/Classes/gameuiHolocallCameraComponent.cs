
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiHolocallCameraComponent : entRenderToTextureCameraComponent
	{
		public gameuiHolocallCameraComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
