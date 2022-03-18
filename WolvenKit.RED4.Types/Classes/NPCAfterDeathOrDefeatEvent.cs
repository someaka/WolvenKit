
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCAfterDeathOrDefeatEvent : redEvent
	{
		public NPCAfterDeathOrDefeatEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
