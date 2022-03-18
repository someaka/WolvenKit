
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TurretEndDecisions : TurretTransition
	{
		public TurretEndDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
