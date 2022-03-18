
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldMirrorNodeInstance : worldMeshNodeInstance
	{
		public worldMirrorNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
