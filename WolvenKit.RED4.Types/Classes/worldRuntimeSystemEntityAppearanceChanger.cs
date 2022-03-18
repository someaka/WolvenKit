
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemEntityAppearanceChanger : worldIRuntimeSystem
	{
		public worldRuntimeSystemEntityAppearanceChanger()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
