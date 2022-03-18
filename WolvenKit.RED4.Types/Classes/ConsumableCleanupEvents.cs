
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ConsumableCleanupEvents : ConsumableTransitions
	{
		public ConsumableCleanupEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
