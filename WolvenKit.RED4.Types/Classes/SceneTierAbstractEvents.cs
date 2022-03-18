
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SceneTierAbstractEvents : SceneTierAbstract
	{
		public SceneTierAbstractEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
