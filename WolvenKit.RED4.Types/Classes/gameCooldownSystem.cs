
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCooldownSystem : gameICooldownSystem
	{
		public gameCooldownSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
