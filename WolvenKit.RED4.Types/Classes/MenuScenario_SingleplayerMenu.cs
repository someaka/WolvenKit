
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MenuScenario_SingleplayerMenu : MenuScenario_PreGameSubMenu
	{
		public MenuScenario_SingleplayerMenu()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
