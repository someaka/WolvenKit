
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ShotgunDualLookAtEvents : lookAtPresetGunBaseEvents
	{
		public ShotgunDualLookAtEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
