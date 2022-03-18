
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CRenderLightVolumeAllocator : ISceneStorageCustomData
	{
		public CRenderLightVolumeAllocator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
