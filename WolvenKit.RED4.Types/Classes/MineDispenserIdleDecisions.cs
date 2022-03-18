
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MineDispenserIdleDecisions : MineDispenserTransition
	{
		public MineDispenserIdleDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
