
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChargeMaxEvents : ChargeEventsAbstract
	{
		public ChargeMaxEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
