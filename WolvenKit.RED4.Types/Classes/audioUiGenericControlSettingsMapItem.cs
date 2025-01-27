using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioUiGenericControlSettingsMapItem : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("uiEventToAudioEventDictionary")] 
		public CHandle<audioKeySoundEventDictionary> UiEventToAudioEventDictionary
		{
			get => GetPropertyValue<CHandle<audioKeySoundEventDictionary>>();
			set => SetPropertyValue<CHandle<audioKeySoundEventDictionary>>(value);
		}
	}
}
