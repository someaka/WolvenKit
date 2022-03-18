
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RandomChancePrereqState : gamePrereqState
	{
		public RandomChancePrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
