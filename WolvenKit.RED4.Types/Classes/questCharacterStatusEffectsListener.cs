
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterStatusEffectsListener : gameIStatusEffectListener
	{
		public questCharacterStatusEffectsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
