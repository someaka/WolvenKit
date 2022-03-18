
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnregisterFromZoomBlackboardEvent : redEvent
	{
		public UnregisterFromZoomBlackboardEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
