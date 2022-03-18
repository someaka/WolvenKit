
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResurrectDecisions : HighLevelTransition
	{
		public ResurrectDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
