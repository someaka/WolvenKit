
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LoopStartedEvent : redEvent
	{
		public LoopStartedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
