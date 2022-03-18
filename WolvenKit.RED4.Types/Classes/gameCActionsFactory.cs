
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCActionsFactory : gameIActionsFactory
	{
		public gameCActionsFactory()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
