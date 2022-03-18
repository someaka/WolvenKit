
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChargeStartedEvent : redEvent
	{
		public ChargeStartedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
