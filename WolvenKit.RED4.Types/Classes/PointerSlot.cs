
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PointerSlot : RadialSlot
	{
		public PointerSlot()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
