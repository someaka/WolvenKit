
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MenuScenario_NewGame : MenuScenario_PreGameSubMenu
	{
		public MenuScenario_NewGame()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
