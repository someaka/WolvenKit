using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MessengerGameController : gameuiMenuGameController
	{
		private inkWidgetReference _buttonHintsManagerRef;
		private inkWidgetReference _contactsRef;
		private inkWidgetReference _dialogRef;
		private inkWidgetReference _virtualList;
		private CWeakHandle<ButtonHints> _buttonHintsController;
		private CWeakHandle<MessengerDialogViewController> _dialogController;
		private CWeakHandle<MessengerContactsVirtualNestedListController> _listController;
		private CWeakHandle<gameJournalManager> _journalManager;
		private CWeakHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CHandle<MessengerContactSyncData> _activeData;

		[Ordinal(3)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(4)] 
		[RED("contactsRef")] 
		public inkWidgetReference ContactsRef
		{
			get => GetProperty(ref _contactsRef);
			set => SetProperty(ref _contactsRef, value);
		}

		[Ordinal(5)] 
		[RED("dialogRef")] 
		public inkWidgetReference DialogRef
		{
			get => GetProperty(ref _dialogRef);
			set => SetProperty(ref _dialogRef, value);
		}

		[Ordinal(6)] 
		[RED("virtualList")] 
		public inkWidgetReference VirtualList
		{
			get => GetProperty(ref _virtualList);
			set => SetProperty(ref _virtualList, value);
		}

		[Ordinal(7)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(8)] 
		[RED("dialogController")] 
		public CWeakHandle<MessengerDialogViewController> DialogController
		{
			get => GetProperty(ref _dialogController);
			set => SetProperty(ref _dialogController, value);
		}

		[Ordinal(9)] 
		[RED("listController")] 
		public CWeakHandle<MessengerContactsVirtualNestedListController> ListController
		{
			get => GetProperty(ref _listController);
			set => SetProperty(ref _listController, value);
		}

		[Ordinal(10)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(11)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(12)] 
		[RED("activeData")] 
		public CHandle<MessengerContactSyncData> ActiveData
		{
			get => GetProperty(ref _activeData);
			set => SetProperty(ref _activeData, value);
		}
	}
}
