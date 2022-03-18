
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CombatQueriesRequest : gameSignalUserData
	{
		public CombatQueriesRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
