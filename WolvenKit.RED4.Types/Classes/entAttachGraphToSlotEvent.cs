
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAttachGraphToSlotEvent : redEvent
	{
		public entAttachGraphToSlotEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
