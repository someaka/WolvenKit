
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entTriggerDestructionEvent : redEvent
	{
		public entTriggerDestructionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
