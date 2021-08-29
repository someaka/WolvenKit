using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioMaterialMeleeSoundDictionaryItem : audioInlinedAudioMetadata
	{
		private CName _key;
		private audioMeleeSound _value;

		[Ordinal(1)] 
		[RED("key")] 
		public CName Key
		{
			get => GetProperty(ref _key);
			set => SetProperty(ref _key, value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public audioMeleeSound Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}
	}
}
