
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HealthCollisionLogic : BonusCollisionLogic
	{
		public HealthCollisionLogic()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
