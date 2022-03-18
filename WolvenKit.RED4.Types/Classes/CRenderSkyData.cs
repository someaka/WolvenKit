
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CRenderSkyData : ISceneStorageCustomData
	{
		public CRenderSkyData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
