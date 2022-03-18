
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MineDispenserUnequipEvents : MineDispenserEventsTransition
	{
		public MineDispenserUnequipEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
