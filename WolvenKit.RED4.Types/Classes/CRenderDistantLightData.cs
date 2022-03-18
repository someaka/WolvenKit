
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CRenderDistantLightData : ISceneStorageCustomData
	{
		public CRenderDistantLightData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
