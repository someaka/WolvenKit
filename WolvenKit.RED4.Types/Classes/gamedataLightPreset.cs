using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataLightPreset : RedBaseClass
	{
		private CName _lightSourcesName;
		private TweakDBID _preset;

		[Ordinal(0)] 
		[RED("lightSourcesName")] 
		public CName LightSourcesName
		{
			get => GetProperty(ref _lightSourcesName);
			set => SetProperty(ref _lightSourcesName, value);
		}

		[Ordinal(1)] 
		[RED("preset")] 
		public TweakDBID Preset
		{
			get => GetProperty(ref _preset);
			set => SetProperty(ref _preset, value);
		}
	}
}
