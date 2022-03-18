
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIProjectileSystem : gameIGameSystem
	{
		public gameIProjectileSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
