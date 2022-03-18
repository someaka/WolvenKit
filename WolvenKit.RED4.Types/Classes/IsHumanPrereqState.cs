
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsHumanPrereqState : gamePrereqState
	{
		public IsHumanPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
