
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MergedMesh : CMesh
	{
		public MergedMesh()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
