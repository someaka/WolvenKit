using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NewCodexEntryUserData : inkGameNotificationData
	{
		private CString _data;

		[Ordinal(6)] 
		[RED("data")] 
		public CString Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
