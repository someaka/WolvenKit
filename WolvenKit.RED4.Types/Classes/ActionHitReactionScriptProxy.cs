
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActionHitReactionScriptProxy : CActionScriptProxy
	{
		public ActionHitReactionScriptProxy()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
