
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RenderTexturePreviewData : ISceneStorageCustomData
	{
		public RenderTexturePreviewData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
