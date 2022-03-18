
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldStaticMeshNodeInstance : worldMeshNodeInstance
	{
		public worldStaticMeshNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
