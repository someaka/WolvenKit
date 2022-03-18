
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Attack_Beam : gameAttack_Continuous
	{
		public Attack_Beam()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
