
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class communitySpawnInitializer : ISerializable
	{
		public communitySpawnInitializer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
