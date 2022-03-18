
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ConfessionCompletedEvent : redEvent
	{
		public ConfessionCompletedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
