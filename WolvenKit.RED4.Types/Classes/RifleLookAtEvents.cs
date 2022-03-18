
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RifleLookAtEvents : lookAtPresetGunBaseEvents
	{
		public RifleLookAtEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
