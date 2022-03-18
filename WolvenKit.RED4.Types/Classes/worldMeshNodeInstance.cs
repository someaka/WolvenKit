
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldMeshNodeInstance : worldSnappableNodeInstance
	{
		public worldMeshNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
