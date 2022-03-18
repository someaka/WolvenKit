
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRenderingScriptInterface : IScriptable
	{
		public worldRenderingScriptInterface()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
