
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIPingSystem : gameIReplicatedGameSystem
	{
		public gameIPingSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
