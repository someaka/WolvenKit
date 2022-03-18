
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gsmStateObserver_SessionChanged : gsmIStateObserver
	{
		public gsmStateObserver_SessionChanged()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
