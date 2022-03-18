
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameaudioFlybySubSystem : gameaudioISoundComponentSubSystem
	{
		public gameaudioFlybySubSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
