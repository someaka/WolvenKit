
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HighLevelTransition : DefaultTransition
	{
		public HighLevelTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
