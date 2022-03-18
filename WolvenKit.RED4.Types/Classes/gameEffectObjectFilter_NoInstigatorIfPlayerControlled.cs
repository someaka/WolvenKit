
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectFilter_NoInstigatorIfPlayerControlled : gameEffectObjectSingleFilter
	{
		public gameEffectObjectFilter_NoInstigatorIfPlayerControlled()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
