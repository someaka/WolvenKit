
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIDamageSystem : gameIReplicatedGameSystem
	{
		public gameIDamageSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
