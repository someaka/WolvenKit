
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectSystem : gameIEffectSystem
	{
		public gameEffectSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
