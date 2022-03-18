
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorBehaviorDelegate : AIbehaviorBehaviorBlackboard
	{
		public AIbehaviorBehaviorDelegate()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
