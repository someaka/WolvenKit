
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorDriveTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		public AIbehaviorDriveTreeNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
