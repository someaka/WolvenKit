
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActiveSkillScreenChangedEvent : redEvent
	{
		public ActiveSkillScreenChangedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
