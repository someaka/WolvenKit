
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameaudioMeleeAudioSubSystem : gameaudioIWeaponAudioComponentSubSystem
	{
		public gameaudioMeleeAudioSubSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
