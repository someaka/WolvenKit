
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TurretBeginDecisions : TurretTransition
	{
		public TurretBeginDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
