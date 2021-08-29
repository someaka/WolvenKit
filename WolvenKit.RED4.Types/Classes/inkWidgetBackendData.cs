using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkWidgetBackendData : IBackendData
	{
		private CWeakHandle<inkWidget> _owner;
		private CBool _isHiddenInEditor;
		private CBool _isLocked;
		private CName _boundLibraryItemName;

		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<inkWidget> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("isHiddenInEditor")] 
		public CBool IsHiddenInEditor
		{
			get => GetProperty(ref _isHiddenInEditor);
			set => SetProperty(ref _isHiddenInEditor, value);
		}

		[Ordinal(2)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetProperty(ref _isLocked);
			set => SetProperty(ref _isLocked, value);
		}

		[Ordinal(3)] 
		[RED("boundLibraryItemName")] 
		public CName BoundLibraryItemName
		{
			get => GetProperty(ref _boundLibraryItemName);
			set => SetProperty(ref _boundLibraryItemName, value);
		}
	}
}
