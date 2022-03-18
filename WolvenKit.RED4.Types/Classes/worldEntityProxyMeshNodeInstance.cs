
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldEntityProxyMeshNodeInstance : worldPrefabProxyMeshNodeInstance
	{
		public worldEntityProxyMeshNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
