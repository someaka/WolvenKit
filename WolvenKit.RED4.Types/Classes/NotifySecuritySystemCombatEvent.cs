
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NotifySecuritySystemCombatEvent : redEvent
	{
		public NotifySecuritySystemCombatEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
