
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioMultiplePositionsStrategy : audioApplySoundPositionStrategy
	{
		public audioMultiplePositionsStrategy()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
