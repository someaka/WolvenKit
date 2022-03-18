
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeactivateQuickHackIndicatorEvent : redEvent
	{
		public DeactivateQuickHackIndicatorEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
