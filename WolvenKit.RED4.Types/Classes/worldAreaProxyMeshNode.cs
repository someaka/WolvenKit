
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAreaProxyMeshNode : worldPrefabProxyMeshNode
	{
		public worldAreaProxyMeshNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
