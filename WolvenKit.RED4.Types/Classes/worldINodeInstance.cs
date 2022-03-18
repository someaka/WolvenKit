
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldINodeInstance : ISerializable
	{
		public worldINodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
