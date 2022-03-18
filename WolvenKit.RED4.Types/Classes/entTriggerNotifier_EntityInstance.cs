
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entTriggerNotifier_EntityInstance : worldITriggerAreaNotiferInstance
	{
		public entTriggerNotifier_EntityInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
