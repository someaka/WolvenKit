
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDeactivateTriggerDestructionComponentEvent : redEvent
	{
		public gameDeactivateTriggerDestructionComponentEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
