
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	[REDClass(SerializeDefault = true)]
	public partial class entWorkspotItemEvent : redEvent
	{
		public entWorkspotItemEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
