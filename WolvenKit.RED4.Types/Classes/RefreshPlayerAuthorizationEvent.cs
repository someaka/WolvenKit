
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RefreshPlayerAuthorizationEvent : redEvent
	{
		public RefreshPlayerAuthorizationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
