
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIBlackboardUpdateProxy : gameIGameSystem
	{
		public gameIBlackboardUpdateProxy()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
