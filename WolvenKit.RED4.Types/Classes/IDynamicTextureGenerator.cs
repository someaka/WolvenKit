
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IDynamicTextureGenerator : ISerializable
	{
		public IDynamicTextureGenerator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
