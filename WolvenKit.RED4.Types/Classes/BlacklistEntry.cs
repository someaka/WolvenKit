using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BlacklistEntry : IScriptable
	{
		private entEntityID _entryID;
		private CEnum<BlacklistReason> _entryReason;
		private CInt32 _warningsCount;
		private CInt32 _reprimandID;

		[Ordinal(0)] 
		[RED("entryID")] 
		public entEntityID EntryID
		{
			get => GetProperty(ref _entryID);
			set => SetProperty(ref _entryID, value);
		}

		[Ordinal(1)] 
		[RED("entryReason")] 
		public CEnum<BlacklistReason> EntryReason
		{
			get => GetProperty(ref _entryReason);
			set => SetProperty(ref _entryReason, value);
		}

		[Ordinal(2)] 
		[RED("warningsCount")] 
		public CInt32 WarningsCount
		{
			get => GetProperty(ref _warningsCount);
			set => SetProperty(ref _warningsCount, value);
		}

		[Ordinal(3)] 
		[RED("reprimandID")] 
		public CInt32 ReprimandID
		{
			get => GetProperty(ref _reprimandID);
			set => SetProperty(ref _reprimandID, value);
		}
	}
}
