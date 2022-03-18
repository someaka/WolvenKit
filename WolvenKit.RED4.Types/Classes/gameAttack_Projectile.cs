
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAttack_Projectile : gameIAttack
	{
		public gameAttack_Projectile()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
