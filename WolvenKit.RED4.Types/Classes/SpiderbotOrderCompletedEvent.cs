
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SpiderbotOrderCompletedEvent : redEvent
	{
		public SpiderbotOrderCompletedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
