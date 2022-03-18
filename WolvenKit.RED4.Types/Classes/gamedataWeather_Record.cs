
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataWeather_Record : gamedataTweakDBRecord
	{
		public gamedataWeather_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
