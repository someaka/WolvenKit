
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IgnoreFriendlyTargets : gameEffectObjectSingleFilter_Scripted
	{
		public IgnoreFriendlyTargets()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
