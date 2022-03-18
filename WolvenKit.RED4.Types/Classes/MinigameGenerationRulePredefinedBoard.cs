
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MinigameGenerationRulePredefinedBoard : gameuiMinigameGenerationRule
	{
		public MinigameGenerationRulePredefinedBoard()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
