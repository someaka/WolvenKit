using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAnimInputSetterVector : entAnimInputSetter
	{
		private Vector4 _value;

		[Ordinal(1)] 
		[RED("value")] 
		public Vector4 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}
	}
}
