
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gsmStateObserver_RichPresence : gsmIStateObserver
	{
		public gsmStateObserver_RichPresence()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
