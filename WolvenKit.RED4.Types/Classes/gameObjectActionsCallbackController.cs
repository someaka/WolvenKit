
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameObjectActionsCallbackController : IScriptable
	{
		public gameObjectActionsCallbackController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
