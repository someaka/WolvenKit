
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entTriggerNotifier_ScriptInstance : worldITriggerAreaNotiferInstance
	{
		public entTriggerNotifier_ScriptInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
