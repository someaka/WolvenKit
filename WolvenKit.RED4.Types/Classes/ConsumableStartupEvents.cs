
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ConsumableStartupEvents : ConsumableTransitions
	{
		public ConsumableStartupEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
