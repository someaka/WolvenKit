
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsProjectedHitEvent : gameeventsHitEvent
	{
		public gameeventsProjectedHitEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
