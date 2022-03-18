
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ClearHitStimEvent : redEvent
	{
		public ClearHitStimEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
