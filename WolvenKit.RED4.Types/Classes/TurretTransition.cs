
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TurretTransition : DefaultTransition
	{
		public TurretTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
