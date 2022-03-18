
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ImageTextureGenerator : IDynamicTextureGenerator
	{
		public ImageTextureGenerator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
