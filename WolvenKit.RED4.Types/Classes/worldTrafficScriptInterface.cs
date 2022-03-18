
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficScriptInterface : IScriptable
	{
		public worldTrafficScriptInterface()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
