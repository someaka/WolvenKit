
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entSpawnersContainer : ISerializable
	{
		public entSpawnersContainer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
