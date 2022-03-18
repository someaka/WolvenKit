
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MenuScenario_LoadGame : MenuScenario_PreGameSubMenu
	{
		public MenuScenario_LoadGame()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
