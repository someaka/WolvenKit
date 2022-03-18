
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIIReactionSystem : gameIGameSystem
	{
		public AIIReactionSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
