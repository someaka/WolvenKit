
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CityLightSystemUpdateEvent : redEvent
	{
		public CityLightSystemUpdateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
