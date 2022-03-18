
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkGameNotificationEvt : redEvent
	{
		public inkGameNotificationEvt()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
