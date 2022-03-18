
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HmgLookAtEvents : lookAtPresetGunBaseEvents
	{
		public HmgLookAtEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
