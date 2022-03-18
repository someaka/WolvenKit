
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entGarmentSkinnedMeshComponent : entSkinnedMeshComponent
	{
		public entGarmentSkinnedMeshComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
