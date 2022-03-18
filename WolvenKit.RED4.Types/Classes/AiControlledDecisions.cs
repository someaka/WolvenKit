
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AiControlledDecisions : HighLevelTransition
	{
		public AiControlledDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
