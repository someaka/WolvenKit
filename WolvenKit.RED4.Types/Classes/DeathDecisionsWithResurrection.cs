
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeathDecisionsWithResurrection : HighLevelTransition
	{
		public DeathDecisionsWithResurrection()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
