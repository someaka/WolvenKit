
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AINavigationSystem : AIINavigationSystem
	{
		public AINavigationSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
