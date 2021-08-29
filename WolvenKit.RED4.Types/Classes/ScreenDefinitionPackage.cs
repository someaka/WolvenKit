using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScreenDefinitionPackage : RedBaseClass
	{
		private CHandle<gamedataDeviceUIDefinition_Record> _screenDefinition;
		private CHandle<gamedataWidgetStyle_Record> _style;

		[Ordinal(0)] 
		[RED("screenDefinition")] 
		public CHandle<gamedataDeviceUIDefinition_Record> ScreenDefinition
		{
			get => GetProperty(ref _screenDefinition);
			set => SetProperty(ref _screenDefinition, value);
		}

		[Ordinal(1)] 
		[RED("style")] 
		public CHandle<gamedataWidgetStyle_Record> Style
		{
			get => GetProperty(ref _style);
			set => SetProperty(ref _style, value);
		}
	}
}
