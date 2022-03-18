
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIStatusEffectSystem : gameIGameSystem
	{
		public gameIStatusEffectSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
