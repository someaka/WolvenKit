
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIReactionSystem : AIIReactionSystem
	{
		public AIReactionSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
