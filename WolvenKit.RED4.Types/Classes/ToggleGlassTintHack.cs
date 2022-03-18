
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ToggleGlassTintHack : ToggleGlassTint
	{
		public ToggleGlassTintHack()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
