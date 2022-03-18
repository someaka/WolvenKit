
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InternalFunctionalTestsRuntimeSystem : FunctionalTestsIRuntimeSystem
	{
		public InternalFunctionalTestsRuntimeSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
