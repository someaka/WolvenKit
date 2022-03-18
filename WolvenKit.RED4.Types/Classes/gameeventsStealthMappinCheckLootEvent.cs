
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsStealthMappinCheckLootEvent : redEvent
	{
		public gameeventsStealthMappinCheckLootEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
