
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldWaterPatchProxyMeshNode : worldPrefabProxyMeshNode
	{
		public worldWaterPatchProxyMeshNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
