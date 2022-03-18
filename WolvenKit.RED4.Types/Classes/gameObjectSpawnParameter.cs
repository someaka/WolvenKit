
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameObjectSpawnParameter : ISerializable
	{
		public gameObjectSpawnParameter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
