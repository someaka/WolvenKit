
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIPuppetUpdaterSystem : gameIGameSystem
	{
		public gameIPuppetUpdaterSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
