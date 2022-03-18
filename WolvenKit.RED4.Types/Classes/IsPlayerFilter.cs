
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsPlayerFilter : gameEffectObjectSingleFilter_Scripted
	{
		public IsPlayerFilter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
