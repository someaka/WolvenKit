
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAutoSaveSystem : gameIAutoSaveSystem
	{
		public gameAutoSaveSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
