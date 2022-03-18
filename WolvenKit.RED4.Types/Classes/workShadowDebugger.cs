
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workShadowDebugger : workDebuggingTool
	{
		public workShadowDebugger()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
