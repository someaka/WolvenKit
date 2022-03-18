
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CRenderTextureMaterial : IDynamicTextureGenerator
	{
		public CRenderTextureMaterial()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
