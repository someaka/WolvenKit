
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickSlotsReadyDecisions : QuickSlotsDecisions
	{
		public QuickSlotsReadyDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
