
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DelayedHandleQuickLoadEvent : redEvent
	{
		public DelayedHandleQuickLoadEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
