
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIEffectSystem : gameIGameSystem
	{
		public gameIEffectSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
