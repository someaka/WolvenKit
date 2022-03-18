
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameICameraSystem : gameIGameSystem
	{
		public gameICameraSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
