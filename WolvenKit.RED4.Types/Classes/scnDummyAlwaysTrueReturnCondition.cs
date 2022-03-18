
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnDummyAlwaysTrueReturnCondition : scnIReturnCondition
	{
		public scnDummyAlwaysTrueReturnCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
