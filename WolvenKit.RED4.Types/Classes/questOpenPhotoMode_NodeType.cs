using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questOpenPhotoMode_NodeType : questIUIManagerNodeType
	{
		private CString _factName;
		private CBool _forceFppMode;
		private CBool _alwaysAllowTPP;
		private CBool _lockExitUntilScreenshot;

		[Ordinal(0)] 
		[RED("factName")] 
		public CString FactName
		{
			get => GetProperty(ref _factName);
			set => SetProperty(ref _factName, value);
		}

		[Ordinal(1)] 
		[RED("forceFppMode")] 
		public CBool ForceFppMode
		{
			get => GetProperty(ref _forceFppMode);
			set => SetProperty(ref _forceFppMode, value);
		}

		[Ordinal(2)] 
		[RED("alwaysAllowTPP")] 
		public CBool AlwaysAllowTPP
		{
			get => GetProperty(ref _alwaysAllowTPP);
			set => SetProperty(ref _alwaysAllowTPP, value);
		}

		[Ordinal(3)] 
		[RED("lockExitUntilScreenshot")] 
		public CBool LockExitUntilScreenshot
		{
			get => GetProperty(ref _lockExitUntilScreenshot);
			set => SetProperty(ref _lockExitUntilScreenshot, value);
		}
	}
}
