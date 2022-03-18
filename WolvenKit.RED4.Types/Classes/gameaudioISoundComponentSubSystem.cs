
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameaudioISoundComponentSubSystem : gameaudioIAudioSubSystem
	{
		public gameaudioISoundComponentSubSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
