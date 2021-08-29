using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class JournalNotificationData : inkGameNotificationData
	{
		private CWeakHandle<gameJournalEntry> _journalEntry;
		private CEnum<gameJournalEntryState> _journalEntryState;
		private CName _className;
		private CBool _menuMode;

		[Ordinal(6)] 
		[RED("journalEntry")] 
		public CWeakHandle<gameJournalEntry> JournalEntry
		{
			get => GetProperty(ref _journalEntry);
			set => SetProperty(ref _journalEntry, value);
		}

		[Ordinal(7)] 
		[RED("journalEntryState")] 
		public CEnum<gameJournalEntryState> JournalEntryState
		{
			get => GetProperty(ref _journalEntryState);
			set => SetProperty(ref _journalEntryState, value);
		}

		[Ordinal(8)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetProperty(ref _className);
			set => SetProperty(ref _className, value);
		}

		[Ordinal(9)] 
		[RED("menuMode")] 
		public CBool MenuMode
		{
			get => GetProperty(ref _menuMode);
			set => SetProperty(ref _menuMode, value);
		}
	}
}
