
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SkillCheckPrereqState : gamePrereqState
	{
		public SkillCheckPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
