
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChargeEndedEvent : redEvent
	{
		public ChargeEndedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
