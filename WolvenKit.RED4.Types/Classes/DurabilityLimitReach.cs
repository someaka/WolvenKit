
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DurabilityLimitReach : redEvent
	{
		public DurabilityLimitReach()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
