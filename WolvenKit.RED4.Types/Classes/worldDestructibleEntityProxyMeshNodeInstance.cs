
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDestructibleEntityProxyMeshNodeInstance : worldEntityProxyMeshNodeInstance
	{
		public worldDestructibleEntityProxyMeshNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
