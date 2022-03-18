
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldPrefabProxyMeshNodeInstance : worldMeshNodeInstance
	{
		public worldPrefabProxyMeshNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
