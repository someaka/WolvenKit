
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResolveSkillchecksEvent : redEvent
	{
		public ResolveSkillchecksEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
