
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AiControlledEvents : HighLevelTransition
	{
		public AiControlledEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
