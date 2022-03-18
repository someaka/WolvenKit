
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entFactory : ISerializable
	{
		public entFactory()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
