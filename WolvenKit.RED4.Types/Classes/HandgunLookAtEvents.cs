
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HandgunLookAtEvents : lookAtPresetGunBaseEvents
	{
		public HandgunLookAtEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
