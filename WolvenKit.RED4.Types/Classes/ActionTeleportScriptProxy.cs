
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActionTeleportScriptProxy : CActionScriptProxy
	{
		public ActionTeleportScriptProxy()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
