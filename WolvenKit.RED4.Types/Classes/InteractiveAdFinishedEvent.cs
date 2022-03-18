
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InteractiveAdFinishedEvent : redEvent
	{
		public InteractiveAdFinishedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
