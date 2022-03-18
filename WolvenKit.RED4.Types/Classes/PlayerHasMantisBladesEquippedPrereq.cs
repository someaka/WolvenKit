
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerHasMantisBladesEquippedPrereq : gameIScriptablePrereq
	{
		public PlayerHasMantisBladesEquippedPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
