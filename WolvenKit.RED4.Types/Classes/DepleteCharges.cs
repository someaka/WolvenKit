
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DepleteCharges : redEvent
	{
		public DepleteCharges()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
