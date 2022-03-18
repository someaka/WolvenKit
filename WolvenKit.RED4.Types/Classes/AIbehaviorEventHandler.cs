
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorEventHandler : RedBaseClass
	{
		public AIbehaviorEventHandler()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
