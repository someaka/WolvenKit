
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entEntityParameter : ISerializable
	{
		public entEntityParameter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
