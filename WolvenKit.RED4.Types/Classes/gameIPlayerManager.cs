
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIPlayerManager : gameIGameSystem
	{
		public gameIPlayerManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
