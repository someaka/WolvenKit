
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIIEntityStubHandlerProviderSystem : gameIGameSystem
	{
		public AIIEntityStubHandlerProviderSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
