
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePingSystem : gameIPingSystem
	{
		public gamePingSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
