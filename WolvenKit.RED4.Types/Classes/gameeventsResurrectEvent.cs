
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsResurrectEvent : redEvent
	{
		public gameeventsResurrectEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
