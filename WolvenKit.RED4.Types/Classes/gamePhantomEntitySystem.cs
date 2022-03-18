
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePhantomEntitySystem : gameIPhantomEntitySystem
	{
		public gamePhantomEntitySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
