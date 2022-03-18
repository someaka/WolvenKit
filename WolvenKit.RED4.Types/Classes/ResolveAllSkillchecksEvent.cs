
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResolveAllSkillchecksEvent : redEvent
	{
		public ResolveAllSkillchecksEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
