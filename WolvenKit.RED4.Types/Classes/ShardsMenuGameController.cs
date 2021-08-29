using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ShardsMenuGameController : gameuiMenuGameController
	{
		private inkWidgetReference _buttonHintsManagerRef;
		private inkCompoundWidgetReference _entryViewRef;
		private inkWidgetReference _virtualList;
		private inkWidgetReference _emptyPlaceholderRef;
		private inkWidgetReference _leftBlockControllerRef;
		private inkWidgetReference _crackHint;
		private CWeakHandle<gameJournalManager> _journalManager;
		private CWeakHandle<ButtonHints> _buttonHintsController;
		private CWeakHandle<CodexEntryViewController> _entryViewController;
		private CWeakHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CWeakHandle<ShardsVirtualNestedListController> _listController;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private CWeakHandle<PlayerPuppet> _player;
		private CHandle<CodexListSyncData> _activeData;
		private CBool _hasNewCryptedEntries;
		private CBool _isEncryptedEntrySelected;
		private CHandle<ShardEntryData> _selectedData;
		private CWeakHandle<gameIBlackboard> _mingameBB;
		private CInt32 _userDataEntry;
		private CBool _doubleInputPreventionFlag;
		private CHandle<inkanimProxy> _animationProxy;

		[Ordinal(3)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(4)] 
		[RED("entryViewRef")] 
		public inkCompoundWidgetReference EntryViewRef
		{
			get => GetProperty(ref _entryViewRef);
			set => SetProperty(ref _entryViewRef, value);
		}

		[Ordinal(5)] 
		[RED("virtualList")] 
		public inkWidgetReference VirtualList
		{
			get => GetProperty(ref _virtualList);
			set => SetProperty(ref _virtualList, value);
		}

		[Ordinal(6)] 
		[RED("emptyPlaceholderRef")] 
		public inkWidgetReference EmptyPlaceholderRef
		{
			get => GetProperty(ref _emptyPlaceholderRef);
			set => SetProperty(ref _emptyPlaceholderRef, value);
		}

		[Ordinal(7)] 
		[RED("leftBlockControllerRef")] 
		public inkWidgetReference LeftBlockControllerRef
		{
			get => GetProperty(ref _leftBlockControllerRef);
			set => SetProperty(ref _leftBlockControllerRef, value);
		}

		[Ordinal(8)] 
		[RED("crackHint")] 
		public inkWidgetReference CrackHint
		{
			get => GetProperty(ref _crackHint);
			set => SetProperty(ref _crackHint, value);
		}

		[Ordinal(9)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(10)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(11)] 
		[RED("entryViewController")] 
		public CWeakHandle<CodexEntryViewController> EntryViewController
		{
			get => GetProperty(ref _entryViewController);
			set => SetProperty(ref _entryViewController, value);
		}

		[Ordinal(12)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(13)] 
		[RED("listController")] 
		public CWeakHandle<ShardsVirtualNestedListController> ListController
		{
			get => GetProperty(ref _listController);
			set => SetProperty(ref _listController, value);
		}

		[Ordinal(14)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(15)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(16)] 
		[RED("activeData")] 
		public CHandle<CodexListSyncData> ActiveData
		{
			get => GetProperty(ref _activeData);
			set => SetProperty(ref _activeData, value);
		}

		[Ordinal(17)] 
		[RED("hasNewCryptedEntries")] 
		public CBool HasNewCryptedEntries
		{
			get => GetProperty(ref _hasNewCryptedEntries);
			set => SetProperty(ref _hasNewCryptedEntries, value);
		}

		[Ordinal(18)] 
		[RED("isEncryptedEntrySelected")] 
		public CBool IsEncryptedEntrySelected
		{
			get => GetProperty(ref _isEncryptedEntrySelected);
			set => SetProperty(ref _isEncryptedEntrySelected, value);
		}

		[Ordinal(19)] 
		[RED("selectedData")] 
		public CHandle<ShardEntryData> SelectedData
		{
			get => GetProperty(ref _selectedData);
			set => SetProperty(ref _selectedData, value);
		}

		[Ordinal(20)] 
		[RED("mingameBB")] 
		public CWeakHandle<gameIBlackboard> MingameBB
		{
			get => GetProperty(ref _mingameBB);
			set => SetProperty(ref _mingameBB, value);
		}

		[Ordinal(21)] 
		[RED("userDataEntry")] 
		public CInt32 UserDataEntry
		{
			get => GetProperty(ref _userDataEntry);
			set => SetProperty(ref _userDataEntry, value);
		}

		[Ordinal(22)] 
		[RED("doubleInputPreventionFlag")] 
		public CBool DoubleInputPreventionFlag
		{
			get => GetProperty(ref _doubleInputPreventionFlag);
			set => SetProperty(ref _doubleInputPreventionFlag, value);
		}

		[Ordinal(23)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}
	}
}
