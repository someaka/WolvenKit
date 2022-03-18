
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDestructibleEntityProxyMeshNode : worldEntityProxyMeshNode
	{
		public worldDestructibleEntityProxyMeshNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
