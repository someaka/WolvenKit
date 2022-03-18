
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ShotgunLookAtEvents : lookAtPresetGunBaseEvents
	{
		public ShotgunLookAtEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
