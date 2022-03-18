
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameISubtitleHandlerSystem : gameIGameSystem
	{
		public gameISubtitleHandlerSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
