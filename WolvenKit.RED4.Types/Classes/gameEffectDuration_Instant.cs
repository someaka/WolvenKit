
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectDuration_Instant : gameEffectDurationModifier
	{
		public gameEffectDuration_Instant()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
