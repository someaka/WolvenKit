
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DespawnSubCharacterRequest : DespawnUniqueSubCharacterRequest
	{
		public DespawnSubCharacterRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
