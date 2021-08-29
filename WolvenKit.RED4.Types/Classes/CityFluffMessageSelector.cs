using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CityFluffMessageSelector : ScreenMessageSelector
	{
		private TweakDBID _recordID;

		[Ordinal(3)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetProperty(ref _recordID);
			set => SetProperty(ref _recordID, value);
		}
	}
}
