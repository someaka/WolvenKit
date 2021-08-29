using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SBaseStateOperationData : RedBaseClass
	{
		private CEnum<EDeviceStatus> _state;
		private SBaseDeviceOperationData _operation;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<EDeviceStatus> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("operation")] 
		public SBaseDeviceOperationData Operation
		{
			get => GetProperty(ref _operation);
			set => SetProperty(ref _operation, value);
		}
	}
}
