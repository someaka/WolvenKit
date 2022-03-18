
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitIsInstigatorPlayerPrereqState : GenericHitPrereqState
	{
		public HitIsInstigatorPlayerPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
