
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsNotInstigatorWeakspotFilter : gameEffectObjectSingleFilter_Scripted
	{
		public IsNotInstigatorWeakspotFilter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
