using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ClueStatusNotification : HUDManagerRequest
	{
		private CBool _isClue;
		private CName _clueGroupID;

		[Ordinal(1)] 
		[RED("isClue")] 
		public CBool IsClue
		{
			get => GetProperty(ref _isClue);
			set => SetProperty(ref _isClue, value);
		}

		[Ordinal(2)] 
		[RED("clueGroupID")] 
		public CName ClueGroupID
		{
			get => GetProperty(ref _clueGroupID);
			set => SetProperty(ref _clueGroupID, value);
		}
	}
}
