
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ReadyDecisions : WeaponReadyListenerTransition
	{
		public ReadyDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
