
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MenuScenario_MultiplayerMenu : MenuScenario_PreGameSubMenu
	{
		public MenuScenario_MultiplayerMenu()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
