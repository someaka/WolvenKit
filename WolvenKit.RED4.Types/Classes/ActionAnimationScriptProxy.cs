
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActionAnimationScriptProxy : CActionScriptProxy
	{
		public ActionAnimationScriptProxy()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
