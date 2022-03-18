
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsTargetHitEvent : gameeventsHitEvent
	{
		public gameeventsTargetHitEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
