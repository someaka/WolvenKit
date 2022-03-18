
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerDeadPrereq : gameIScriptablePrereq
	{
		public PlayerDeadPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
