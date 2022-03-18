
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameActivateTriggerDestructionComponentEvent : redEvent
	{
		public gameActivateTriggerDestructionComponentEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
