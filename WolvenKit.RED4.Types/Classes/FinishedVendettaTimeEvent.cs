
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FinishedVendettaTimeEvent : redEvent
	{
		public FinishedVendettaTimeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
