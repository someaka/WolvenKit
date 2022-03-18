
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioNullPositionStrategy : audioApplySoundPositionStrategy
	{
		public audioNullPositionStrategy()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
