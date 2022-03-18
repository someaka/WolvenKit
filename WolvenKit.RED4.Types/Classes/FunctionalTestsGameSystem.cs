
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FunctionalTestsGameSystem : FunctionalTestsIGameSystem
	{
		public FunctionalTestsGameSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
