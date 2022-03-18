
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerHasNanoWiresEquippedPrereq : gameIScriptablePrereq
	{
		public PlayerHasNanoWiresEquippedPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
