
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioIndexedSinglePositionStrategy : audioApplySoundPositionStrategy
	{
		public audioIndexedSinglePositionStrategy()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
