
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisableAlarmEvent : redEvent
	{
		public DisableAlarmEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
