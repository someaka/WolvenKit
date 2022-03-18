
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameICommunitySystem : gameIGameSystem
	{
		public gameICommunitySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
