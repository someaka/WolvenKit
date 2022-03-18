
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameITimeSystem : gameIReplicatedGameSystem
	{
		public gameITimeSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
