
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MineDispenserTransition : DefaultTransition
	{
		public MineDispenserTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
