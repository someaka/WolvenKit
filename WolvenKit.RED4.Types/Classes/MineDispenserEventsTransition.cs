
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MineDispenserEventsTransition : MineDispenserTransition
	{
		public MineDispenserEventsTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
