
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldWeatherScriptListener : IScriptable
	{
		public worldWeatherScriptListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
