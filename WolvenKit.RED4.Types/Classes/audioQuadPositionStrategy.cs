
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioQuadPositionStrategy : audioApplySoundPositionStrategy
	{
		public audioQuadPositionStrategy()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
