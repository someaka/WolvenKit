
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckComfortZoneEvent : redEvent
	{
		public CheckComfortZoneEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
