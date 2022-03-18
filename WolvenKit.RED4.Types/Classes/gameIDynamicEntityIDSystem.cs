
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIDynamicEntityIDSystem : gameIGameSystem
	{
		public gameIDynamicEntityIDSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
