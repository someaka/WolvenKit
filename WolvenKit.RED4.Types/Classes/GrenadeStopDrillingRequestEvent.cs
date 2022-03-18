
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GrenadeStopDrillingRequestEvent : redEvent
	{
		public GrenadeStopDrillingRequestEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
