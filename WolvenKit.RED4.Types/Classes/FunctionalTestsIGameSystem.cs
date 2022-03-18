
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FunctionalTestsIGameSystem : gameIGameSystem
	{
		public FunctionalTestsIGameSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
