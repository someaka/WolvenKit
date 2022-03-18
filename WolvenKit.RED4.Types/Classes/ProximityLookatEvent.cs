
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ProximityLookatEvent : redEvent
	{
		public ProximityLookatEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
