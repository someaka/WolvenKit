
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiRequestResetContextEvent : redEvent
	{
		public gameuiRequestResetContextEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
