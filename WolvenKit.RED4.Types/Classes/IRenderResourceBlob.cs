
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IRenderResourceBlob : ISerializable
	{
		public IRenderResourceBlob()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
