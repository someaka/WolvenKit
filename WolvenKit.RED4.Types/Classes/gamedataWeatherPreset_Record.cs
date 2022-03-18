
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataWeatherPreset_Record : gamedataSpawnableObject_Record
	{
		public gamedataWeatherPreset_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
