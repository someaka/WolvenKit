
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameISchematicSystem : gameIGameSystem
	{
		public gameISchematicSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
