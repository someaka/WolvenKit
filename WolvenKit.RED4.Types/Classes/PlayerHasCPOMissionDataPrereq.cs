
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerHasCPOMissionDataPrereq : gameIScriptablePrereq
	{
		public PlayerHasCPOMissionDataPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
