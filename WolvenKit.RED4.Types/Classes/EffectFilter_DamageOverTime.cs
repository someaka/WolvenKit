
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EffectFilter_DamageOverTime : gameEffectObjectSingleFilter_Scripted
	{
		public EffectFilter_DamageOverTime()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
