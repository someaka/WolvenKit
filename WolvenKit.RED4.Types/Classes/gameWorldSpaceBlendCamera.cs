
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameWorldSpaceBlendCamera : entBaseCameraComponent
	{
		public gameWorldSpaceBlendCamera()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
