
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MineDispenserCycleItemEvents : MineDispenserEventsTransition
	{
		public MineDispenserCycleItemEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
