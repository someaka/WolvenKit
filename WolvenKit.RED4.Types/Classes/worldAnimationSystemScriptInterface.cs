
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAnimationSystemScriptInterface : IScriptable
	{
		public worldAnimationSystemScriptInterface()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
