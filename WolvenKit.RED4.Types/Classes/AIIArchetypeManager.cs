
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIIArchetypeManager : gameIGameSystem
	{
		public AIIArchetypeManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
