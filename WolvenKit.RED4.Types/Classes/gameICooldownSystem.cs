
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameICooldownSystem : gameIGameSystem
	{
		public gameICooldownSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
