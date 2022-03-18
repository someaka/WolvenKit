
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetLookatReactionEvent : redEvent
	{
		public ResetLookatReactionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
