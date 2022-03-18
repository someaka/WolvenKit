
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnScriptInterface : IScriptable
	{
		public scnScriptInterface()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
