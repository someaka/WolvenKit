
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnISceneSystem : gameISceneSystem
	{
		public scnISceneSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
