
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectFilter_NoDuplicates : gameEffectObjectGroupFilter
	{
		public gameEffectObjectFilter_NoDuplicates()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
