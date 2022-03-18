
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICondition : IScriptable
	{
		public AICondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
