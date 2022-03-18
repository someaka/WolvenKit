
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BluelineConditionTypeBase : ScriptConditionTypeBase
	{
		public BluelineConditionTypeBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
