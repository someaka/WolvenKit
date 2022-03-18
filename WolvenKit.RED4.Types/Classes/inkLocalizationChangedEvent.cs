
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkLocalizationChangedEvent : inkEvent
	{
		public inkLocalizationChangedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
