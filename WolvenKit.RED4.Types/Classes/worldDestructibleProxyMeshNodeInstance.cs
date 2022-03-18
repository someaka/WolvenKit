
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDestructibleProxyMeshNodeInstance : worldPrefabProxyMeshNodeInstance
	{
		public worldDestructibleProxyMeshNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
