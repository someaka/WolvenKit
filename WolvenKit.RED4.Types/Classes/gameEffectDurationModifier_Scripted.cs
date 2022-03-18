
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectDurationModifier_Scripted : gameEffectDurationModifier
	{
		public gameEffectDurationModifier_Scripted()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
