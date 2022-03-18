
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SniperRifleLookAtDecisions : lookAtPresetGunBaseDecisions
	{
		public SniperRifleLookAtDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
