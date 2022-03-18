
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsEndTakedownEvent : redEvent
	{
		public gameeventsEndTakedownEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
