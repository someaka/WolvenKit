
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gsmStateObserver_UserSignInOut : gsmIStateObserver
	{
		public gsmStateObserver_UserSignInOut()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
