
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DischargeDecisions : WeaponTransition
	{
		public DischargeDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
