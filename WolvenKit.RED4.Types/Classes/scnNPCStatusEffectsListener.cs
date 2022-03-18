
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnNPCStatusEffectsListener : gameIStatusEffectListener
	{
		public scnNPCStatusEffectsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
