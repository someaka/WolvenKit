using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioFoleyAppearanceName : audioAudioMetadata
	{
		private CBool _void;

		[Ordinal(1)] 
		[RED("void")] 
		public CBool Void
		{
			get => GetProperty(ref _void);
			set => SetProperty(ref _void, value);
		}
	}
}
