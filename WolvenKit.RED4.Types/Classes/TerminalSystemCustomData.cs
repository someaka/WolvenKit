using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TerminalSystemCustomData : WidgetCustomData
	{
		[Ordinal(0)] 
		[RED("connectedDevices")] 
		public CInt32 ConnectedDevices
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
