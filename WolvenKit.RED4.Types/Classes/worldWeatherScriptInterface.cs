
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldWeatherScriptInterface : IScriptable
	{
		public worldWeatherScriptInterface()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
