
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SpawnSubCharacterRequest : SpawnUniqueSubCharacterRequest
	{
		public SpawnSubCharacterRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
