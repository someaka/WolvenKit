
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChargeEvents : ChargeEventsAbstract
	{
		public ChargeEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
