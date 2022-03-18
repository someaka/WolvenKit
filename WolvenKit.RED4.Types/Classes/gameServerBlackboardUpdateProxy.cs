
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameServerBlackboardUpdateProxy : gameBlackboardUpdateProxy
	{
		public gameServerBlackboardUpdateProxy()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
