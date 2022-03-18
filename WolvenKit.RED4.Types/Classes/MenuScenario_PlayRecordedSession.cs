
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MenuScenario_PlayRecordedSession : MenuScenario_PreGameSubMenu
	{
		public MenuScenario_PlayRecordedSession()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
