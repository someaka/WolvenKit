
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameISceneSystem : gameIGameSystem
	{
		public gameISceneSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
