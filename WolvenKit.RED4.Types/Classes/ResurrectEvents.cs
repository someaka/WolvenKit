
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResurrectEvents : HighLevelTransition
	{
		public ResurrectEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
