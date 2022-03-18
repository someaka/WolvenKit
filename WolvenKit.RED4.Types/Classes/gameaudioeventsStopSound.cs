using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameaudioeventsStopSound : redEvent
	{
		[Ordinal(0)] 
		[RED("soundName")] 
		public CName SoundName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameaudioeventsStopSound()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
