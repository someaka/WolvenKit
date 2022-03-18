
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RevolverLookAtEvents : lookAtPresetGunBaseEvents
	{
		public RevolverLookAtEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
