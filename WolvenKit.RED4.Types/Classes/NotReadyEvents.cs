
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NotReadyEvents : WeaponEventsTransition
	{
		public NotReadyEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
