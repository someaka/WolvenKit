using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIScriptActionDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)] 
		[RED("actionPackageType")] 
		public CEnum<AIactionParamsPackageTypes> ActionPackageType
		{
			get => GetPropertyValue<CEnum<AIactionParamsPackageTypes>>();
			set => SetPropertyValue<CEnum<AIactionParamsPackageTypes>>(value);
		}
	}
}
