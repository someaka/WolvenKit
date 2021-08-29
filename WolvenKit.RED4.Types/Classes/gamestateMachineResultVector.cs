using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineResultVector : RedBaseClass
	{
		private Vector4 _value;
		private CBool _valid;

		[Ordinal(0)] 
		[RED("value")] 
		public Vector4 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(1)] 
		[RED("valid")] 
		public CBool Valid
		{
			get => GetProperty(ref _valid);
			set => SetProperty(ref _valid, value);
		}
	}
}
