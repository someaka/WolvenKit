
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerNotCarryingPrereq : gameIScriptablePrereq
	{
		public PlayerNotCarryingPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
