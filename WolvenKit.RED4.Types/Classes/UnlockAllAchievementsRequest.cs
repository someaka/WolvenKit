
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnlockAllAchievementsRequest : gameScriptableSystemRequest
	{
		public UnlockAllAchievementsRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
