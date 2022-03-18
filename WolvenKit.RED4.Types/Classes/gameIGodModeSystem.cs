
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIGodModeSystem : gameIReplicatedGameSystem
	{
		public gameIGodModeSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
