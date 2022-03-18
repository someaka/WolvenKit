
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerNotInBraindancePrereq : gameIScriptablePrereq
	{
		public PlayerNotInBraindancePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
