
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldWeatherAreaNotifierInstance : worldITriggerAreaNotiferInstance
	{
		public worldWeatherAreaNotifierInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
