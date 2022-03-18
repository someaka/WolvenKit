
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldGenericProxyMeshNode : worldPrefabProxyMeshNode
	{
		public worldGenericProxyMeshNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
