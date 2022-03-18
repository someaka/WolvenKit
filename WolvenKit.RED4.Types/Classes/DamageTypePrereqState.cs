
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DamageTypePrereqState : GenericHitPrereqState
	{
		public DamageTypePrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
