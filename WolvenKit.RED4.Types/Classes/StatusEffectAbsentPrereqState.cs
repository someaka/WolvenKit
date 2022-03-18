
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatusEffectAbsentPrereqState : StatusEffectPrereqState
	{
		public StatusEffectAbsentPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
