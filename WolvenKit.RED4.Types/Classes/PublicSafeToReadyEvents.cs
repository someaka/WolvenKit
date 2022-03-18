
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PublicSafeToReadyEvents : WeaponEventsTransition
	{
		public PublicSafeToReadyEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
