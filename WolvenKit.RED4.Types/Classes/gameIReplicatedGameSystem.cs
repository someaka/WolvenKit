
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIReplicatedGameSystem : gameIGameSystem
	{
		public gameIReplicatedGameSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
