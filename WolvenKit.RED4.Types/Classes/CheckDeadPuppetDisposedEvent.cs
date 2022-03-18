
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckDeadPuppetDisposedEvent : redEvent
	{
		public CheckDeadPuppetDisposedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
