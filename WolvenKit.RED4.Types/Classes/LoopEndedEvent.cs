
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LoopEndedEvent : redEvent
	{
		public LoopEndedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
