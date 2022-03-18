
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NotifyParentsEvent : redEvent
	{
		public NotifyParentsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
