
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MineDispenserIdleEvents : MineDispenserEventsTransition
	{
		public MineDispenserIdleEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
