
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SceneCustomData_Selection : ISceneStorageCustomData
	{
		public SceneCustomData_Selection()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
