
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GrenadeReleaseRequestEvent : redEvent
	{
		public GrenadeReleaseRequestEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
