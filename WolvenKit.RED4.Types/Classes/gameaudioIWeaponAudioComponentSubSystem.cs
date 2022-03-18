
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameaudioIWeaponAudioComponentSubSystem : gameaudioIAudioSubSystem
	{
		public gameaudioIWeaponAudioComponentSubSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
