using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkRadioGroupController : inkWidgetLogicController
	{
		private CArray<inkWidgetReference> _toggleRefs;
		private CBool _alwaysToggled;
		private CInt32 _selectedIndex;
		private inkRadioGroupChangedCallback _valueChanged;

		[Ordinal(1)] 
		[RED("toggleRefs")] 
		public CArray<inkWidgetReference> ToggleRefs
		{
			get => GetProperty(ref _toggleRefs);
			set => SetProperty(ref _toggleRefs, value);
		}

		[Ordinal(2)] 
		[RED("alwaysToggled")] 
		public CBool AlwaysToggled
		{
			get => GetProperty(ref _alwaysToggled);
			set => SetProperty(ref _alwaysToggled, value);
		}

		[Ordinal(3)] 
		[RED("selectedIndex")] 
		public CInt32 SelectedIndex
		{
			get => GetProperty(ref _selectedIndex);
			set => SetProperty(ref _selectedIndex, value);
		}

		[Ordinal(4)] 
		[RED("ValueChanged")] 
		public inkRadioGroupChangedCallback ValueChanged
		{
			get => GetProperty(ref _valueChanged);
			set => SetProperty(ref _valueChanged, value);
		}
	}
}
