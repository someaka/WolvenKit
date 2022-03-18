
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	[REDClass(SerializeDefault = true)]
	public partial class gsmStateObserver_SessionAutomation : gsmIStateObserver
	{
		public gsmStateObserver_SessionAutomation()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
