
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDynamicMeshNodeInstance : worldMeshNodeInstance
	{
		public worldDynamicMeshNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
