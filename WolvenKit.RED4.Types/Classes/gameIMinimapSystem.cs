
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIMinimapSystem : gameIGameSystem
	{
		public gameIMinimapSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
