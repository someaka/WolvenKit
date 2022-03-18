
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IndustrialArmDamageEvent : redEvent
	{
		public IndustrialArmDamageEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
