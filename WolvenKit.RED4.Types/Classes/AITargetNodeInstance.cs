
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AITargetNodeInstance : AIITarget
	{
		public AITargetNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
