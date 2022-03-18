
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetAttackBlockedBlackBoardValue : redEvent
	{
		public ResetAttackBlockedBlackBoardValue()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
