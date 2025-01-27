using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectInputParameter_Int : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("evaluator")] 
		public CHandle<gameIEffectParameter_IntEvaluator> Evaluator
		{
			get => GetPropertyValue<CHandle<gameIEffectParameter_IntEvaluator>>();
			set => SetPropertyValue<CHandle<gameIEffectParameter_IntEvaluator>>(value);
		}
	}
}
