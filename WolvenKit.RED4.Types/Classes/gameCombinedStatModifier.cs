
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCombinedStatModifier : gameStatModifierBase
	{
		public gameCombinedStatModifier()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
