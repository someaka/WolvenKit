
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIINavigationSystem : gameIGameSystem
	{
		public AIINavigationSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
