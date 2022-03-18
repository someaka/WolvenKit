
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MenuScenario_CharacterCustomization : MenuScenario_PreGameSubMenu
	{
		public MenuScenario_CharacterCustomization()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
