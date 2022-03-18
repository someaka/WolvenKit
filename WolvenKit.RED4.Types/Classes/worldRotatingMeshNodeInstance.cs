
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRotatingMeshNodeInstance : worldMeshNodeInstance
	{
		public worldRotatingMeshNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
