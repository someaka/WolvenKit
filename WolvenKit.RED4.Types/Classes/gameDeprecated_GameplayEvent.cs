
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDeprecated_GameplayEvent : redEvent
	{
		public gameDeprecated_GameplayEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
