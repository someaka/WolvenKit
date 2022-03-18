
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DetectorModuleComponent : gameScriptableComponent
	{
		public DetectorModuleComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
