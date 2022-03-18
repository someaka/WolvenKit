
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChargeReadyEvents : ChargeEventsAbstract
	{
		public ChargeReadyEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
