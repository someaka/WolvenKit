
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePlayerManager : gameIPlayerManager
	{
		public gamePlayerManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
