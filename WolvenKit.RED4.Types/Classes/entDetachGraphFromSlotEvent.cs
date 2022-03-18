
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entDetachGraphFromSlotEvent : redEvent
	{
		public entDetachGraphFromSlotEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
