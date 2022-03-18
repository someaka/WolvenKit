
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAIDirectorSpawnMarker : worldIMarker
	{
		public worldAIDirectorSpawnMarker()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
