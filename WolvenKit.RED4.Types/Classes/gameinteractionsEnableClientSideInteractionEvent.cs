
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsEnableClientSideInteractionEvent : redEvent
	{
		public gameinteractionsEnableClientSideInteractionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
