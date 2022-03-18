
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendRenderMultilayerMaskBlobXboxOne : rendRenderMultilayerMaskBlob
	{
		public rendRenderMultilayerMaskBlobXboxOne()
		{
			Header = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
