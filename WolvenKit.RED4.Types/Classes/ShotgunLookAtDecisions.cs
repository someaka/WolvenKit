
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ShotgunLookAtDecisions : lookAtPresetGunBaseDecisions
	{
		public ShotgunLookAtDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
