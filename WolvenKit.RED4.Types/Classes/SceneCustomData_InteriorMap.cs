
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SceneCustomData_InteriorMap : ISceneStorageCustomData
	{
		public SceneCustomData_InteriorMap()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
