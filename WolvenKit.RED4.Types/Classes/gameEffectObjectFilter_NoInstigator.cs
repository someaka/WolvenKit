
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectFilter_NoInstigator : gameEffectObjectGroupFilter
	{
		public gameEffectObjectFilter_NoInstigator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
