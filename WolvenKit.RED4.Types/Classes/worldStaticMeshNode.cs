
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldStaticMeshNode : worldMeshNode
	{
		public worldStaticMeshNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
