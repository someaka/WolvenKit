
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCompanionSystem : gameICompanionSystem
	{
		public gameCompanionSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
