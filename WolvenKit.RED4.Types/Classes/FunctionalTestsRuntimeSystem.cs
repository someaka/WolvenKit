
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FunctionalTestsRuntimeSystem : FunctionalTestsIRuntimeSystem
	{
		public FunctionalTestsRuntimeSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
