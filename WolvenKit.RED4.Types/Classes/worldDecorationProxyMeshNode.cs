
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDecorationProxyMeshNode : worldPrefabProxyMeshNode
	{
		public worldDecorationProxyMeshNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
