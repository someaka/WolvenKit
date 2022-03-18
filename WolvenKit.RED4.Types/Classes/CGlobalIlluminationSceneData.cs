
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CGlobalIlluminationSceneData : ISceneStorageCustomData
	{
		public CGlobalIlluminationSceneData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
