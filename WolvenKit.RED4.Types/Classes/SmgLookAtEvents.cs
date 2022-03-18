
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SmgLookAtEvents : lookAtPresetGunBaseEvents
	{
		public SmgLookAtEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
