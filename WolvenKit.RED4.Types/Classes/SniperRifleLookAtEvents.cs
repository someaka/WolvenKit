
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SniperRifleLookAtEvents : lookAtPresetGunBaseEvents
	{
		public SniperRifleLookAtEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
