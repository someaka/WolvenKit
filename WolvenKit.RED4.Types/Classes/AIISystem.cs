
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIISystem : gameIGameSystem
	{
		public AIISystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
