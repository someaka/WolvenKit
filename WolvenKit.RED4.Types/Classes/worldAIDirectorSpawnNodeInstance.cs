
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAIDirectorSpawnNodeInstance : worldINodeInstance
	{
		public worldAIDirectorSpawnNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
