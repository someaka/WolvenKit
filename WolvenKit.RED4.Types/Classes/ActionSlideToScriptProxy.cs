
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActionSlideToScriptProxy : CActionScriptProxy
	{
		public ActionSlideToScriptProxy()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
