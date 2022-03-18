
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePuppetUpdaterSystem : gameIPuppetUpdaterSystem
	{
		public gamePuppetUpdaterSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
