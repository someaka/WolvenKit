
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIAIDirectorSystem : gameIGameSystem
	{
		public gameIAIDirectorSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
