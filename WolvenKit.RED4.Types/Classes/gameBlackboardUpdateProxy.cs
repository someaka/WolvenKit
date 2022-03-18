
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameBlackboardUpdateProxy : gameIBlackboardUpdateProxy
	{
		public gameBlackboardUpdateProxy()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
