
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataAISquadClosestToTargetCheck_Record : gamedataAISquadDistanceRelationToTargetCheck_Record
	{
		public gamedataAISquadClosestToTargetCheck_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
