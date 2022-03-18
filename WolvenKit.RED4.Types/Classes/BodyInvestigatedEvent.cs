
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BodyInvestigatedEvent : redEvent
	{
		public BodyInvestigatedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
