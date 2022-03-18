
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldNavigationScriptInterface : IScriptable
	{
		public worldNavigationScriptInterface()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
