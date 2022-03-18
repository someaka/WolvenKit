
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SceneCustomData_ShadowManager : ISceneStorageCustomData
	{
		public SceneCustomData_ShadowManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
