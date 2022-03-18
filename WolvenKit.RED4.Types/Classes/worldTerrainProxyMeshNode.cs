
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTerrainProxyMeshNode : worldPrefabProxyMeshNode
	{
		public worldTerrainProxyMeshNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
