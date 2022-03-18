
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIActionsFactory : gameIGameSystem
	{
		public gameIActionsFactory()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
