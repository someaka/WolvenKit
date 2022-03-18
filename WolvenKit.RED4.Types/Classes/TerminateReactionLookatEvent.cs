
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TerminateReactionLookatEvent : redEvent
	{
		public TerminateReactionLookatEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
