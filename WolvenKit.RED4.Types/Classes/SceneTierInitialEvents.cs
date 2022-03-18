
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SceneTierInitialEvents : SceneTierAbstract
	{
		public SceneTierInitialEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
