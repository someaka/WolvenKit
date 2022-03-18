
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameProjectileSystem : gameIProjectileSystem
	{
		public gameProjectileSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
