
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorInstance : RedBaseClass
	{
		public AIbehaviorInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
