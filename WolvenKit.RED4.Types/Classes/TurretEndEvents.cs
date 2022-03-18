
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TurretEndEvents : TurretTransition
	{
		public TurretEndEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
