
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameICompanionSystem : gameIGameSystem
	{
		public gameICompanionSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
