
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActionDodgeScriptProxy : CActionScriptProxy
	{
		public ActionDodgeScriptProxy()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
