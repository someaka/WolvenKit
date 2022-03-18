
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WorldFunctionalTests : IScriptable
	{
		public WorldFunctionalTests()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
