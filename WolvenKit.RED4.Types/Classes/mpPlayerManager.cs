
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class mpPlayerManager : gameIPlayerManager
	{
		public mpPlayerManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
