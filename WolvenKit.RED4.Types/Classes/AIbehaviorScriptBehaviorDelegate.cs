
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorScriptBehaviorDelegate : AIbehaviorBehaviorDelegate
	{
		public AIbehaviorScriptBehaviorDelegate()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
