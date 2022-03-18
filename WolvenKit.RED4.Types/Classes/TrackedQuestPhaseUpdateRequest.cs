
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TrackedQuestPhaseUpdateRequest : redEvent
	{
		public TrackedQuestPhaseUpdateRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
