
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectDuration_Infinite : gameEffectDurationModifier
	{
		public gameEffectDuration_Infinite()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
