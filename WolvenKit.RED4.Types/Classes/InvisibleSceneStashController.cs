
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InvisibleSceneStashController : ScriptableDeviceComponent
	{
		public InvisibleSceneStashController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
