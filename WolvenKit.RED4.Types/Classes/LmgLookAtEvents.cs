
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LmgLookAtEvents : lookAtPresetGunBaseEvents
	{
		public LmgLookAtEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
