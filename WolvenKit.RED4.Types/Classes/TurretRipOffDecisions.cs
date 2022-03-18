
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TurretRipOffDecisions : TurretTransition
	{
		public TurretRipOffDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
