
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScriptableVirtualCameraViewComponent : entVirtualCameraViewComponent
	{
		public ScriptableVirtualCameraViewComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
