
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CycleObjectiveEvents : QuickSlotsTapEvents
	{
		public CycleObjectiveEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
