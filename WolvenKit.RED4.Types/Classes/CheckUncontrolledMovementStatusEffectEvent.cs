
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckUncontrolledMovementStatusEffectEvent : redEvent
	{
		public CheckUncontrolledMovementStatusEffectEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
