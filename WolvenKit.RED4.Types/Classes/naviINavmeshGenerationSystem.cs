
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class naviINavmeshGenerationSystem : gameIGameSystem
	{
		public naviINavmeshGenerationSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
