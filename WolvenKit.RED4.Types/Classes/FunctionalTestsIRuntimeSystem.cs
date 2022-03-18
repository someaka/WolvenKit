
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FunctionalTestsIRuntimeSystem : worldIRuntimeSystem
	{
		public FunctionalTestsIRuntimeSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
