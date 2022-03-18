
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NotReadyDecisions : WeaponReadyListenerTransition
	{
		public NotReadyDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
