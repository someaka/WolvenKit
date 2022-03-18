
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CRenderTerrainCellCollector : ISceneStorageCustomData
	{
		public CRenderTerrainCellCollector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
