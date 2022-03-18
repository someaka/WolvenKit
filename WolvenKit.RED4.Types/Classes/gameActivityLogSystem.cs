
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameActivityLogSystem : gameIActivityLogSystem
	{
		public gameActivityLogSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
