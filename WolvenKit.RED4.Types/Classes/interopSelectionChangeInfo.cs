using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class interopSelectionChangeInfo : RedBaseClass
	{
		private CArray<CUInt64> _selected;
		private CArray<CUInt64> _deselected;

		[Ordinal(0)] 
		[RED("selected")] 
		public CArray<CUInt64> Selected
		{
			get => GetProperty(ref _selected);
			set => SetProperty(ref _selected, value);
		}

		[Ordinal(1)] 
		[RED("deselected")] 
		public CArray<CUInt64> Deselected
		{
			get => GetProperty(ref _deselected);
			set => SetProperty(ref _deselected, value);
		}
	}
}
