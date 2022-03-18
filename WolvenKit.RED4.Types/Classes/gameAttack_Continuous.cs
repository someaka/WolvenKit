
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAttack_Continuous : gameAttack_GameEffect
	{
		public gameAttack_Continuous()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
