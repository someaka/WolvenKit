
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIEntityStubHandlerProviderSystem : AIIEntityStubHandlerProviderSystem
	{
		public AIEntityStubHandlerProviderSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
