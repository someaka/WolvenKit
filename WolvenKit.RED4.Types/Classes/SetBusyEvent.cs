
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetBusyEvent : redEvent
	{
		public SetBusyEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
