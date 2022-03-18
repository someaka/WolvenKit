
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldInstancedDestructibleMeshNodeInstance : worldMeshNodeInstance
	{
		public worldInstancedDestructibleMeshNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
