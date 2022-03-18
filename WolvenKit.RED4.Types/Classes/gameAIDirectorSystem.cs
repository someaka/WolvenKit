
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAIDirectorSystem : gameIAIDirectorSystem
	{
		public gameAIDirectorSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
