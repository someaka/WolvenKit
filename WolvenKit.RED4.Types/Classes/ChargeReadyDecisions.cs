
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChargeReadyDecisions : WeaponTransition
	{
		public ChargeReadyDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
