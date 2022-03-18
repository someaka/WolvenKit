
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CRenderLightVolumeCollector : ICameraStorageCustomData
	{
		public CRenderLightVolumeCollector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
