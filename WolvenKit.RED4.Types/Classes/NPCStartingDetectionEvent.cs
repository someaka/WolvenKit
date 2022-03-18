
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCStartingDetectionEvent : redEvent
	{
		public NPCStartingDetectionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
