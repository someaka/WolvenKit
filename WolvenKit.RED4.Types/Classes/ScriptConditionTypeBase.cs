
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScriptConditionTypeBase : IScriptable
	{
		public ScriptConditionTypeBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
