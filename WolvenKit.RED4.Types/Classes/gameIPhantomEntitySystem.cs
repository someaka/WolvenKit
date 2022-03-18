
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIPhantomEntitySystem : gameIGameSystem
	{
		public gameIPhantomEntitySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
