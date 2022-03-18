
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GrenadeDetonateRequestEvent : redEvent
	{
		public GrenadeDetonateRequestEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
