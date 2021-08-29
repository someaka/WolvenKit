using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class interopGlobalNodeIDInfo : RedBaseClass
	{
		private CString _globalName;
		private CString _globalNodeIDPath;
		private CUInt64 _globalNodeIDHash;
		private CBool _globalNameIsAutoGenerated;

		[Ordinal(0)] 
		[RED("globalName")] 
		public CString GlobalName
		{
			get => GetProperty(ref _globalName);
			set => SetProperty(ref _globalName, value);
		}

		[Ordinal(1)] 
		[RED("globalNodeIDPath")] 
		public CString GlobalNodeIDPath
		{
			get => GetProperty(ref _globalNodeIDPath);
			set => SetProperty(ref _globalNodeIDPath, value);
		}

		[Ordinal(2)] 
		[RED("globalNodeIDHash")] 
		public CUInt64 GlobalNodeIDHash
		{
			get => GetProperty(ref _globalNodeIDHash);
			set => SetProperty(ref _globalNodeIDHash, value);
		}

		[Ordinal(3)] 
		[RED("globalNameIsAutoGenerated")] 
		public CBool GlobalNameIsAutoGenerated
		{
			get => GetProperty(ref _globalNameIsAutoGenerated);
			set => SetProperty(ref _globalNameIsAutoGenerated, value);
		}
	}
}
