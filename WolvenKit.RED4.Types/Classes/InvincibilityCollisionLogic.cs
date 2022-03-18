
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InvincibilityCollisionLogic : BonusCollisionLogic
	{
		public InvincibilityCollisionLogic()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
